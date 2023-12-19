using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPanel : MonoBehaviour
{
    private SkillCoolDown skillCoolDown;
    public delegate void onSkillUseChange();
    public onSkillUseChange onSkillUseChangeCallBack;

    public delegate void onSelectedChange();
    public onSelectedChange onSelectedSkillChange;
    public GameObject skillParent;
    public GameObject skillRowPrefab;
    #region Singleton
    public static SkillPanel instance;
    public SkillRow[] skillRows;
    public InventorySlot currentSlot;
    public InventorySlot selectedSlot;
    void Awake ()
    {
        instance = this;
    }
    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        skillCoolDown = SkillCoolDown.instance;
        onSkillUseChangeCallBack += UpdateUI;
        onSelectedSkillChange += SelectedSkill;
    }
    private void SelectedSkill()
    {
        if (skillRows.Length > 0)
        {
            for (int i = 0; i < skillRows.Length; i++)
            {
                skillRows[i].slot.backGImage.material = null;
            }
        }
        selectedSlot.backGImage.material = UiManager.instance.skillMaterial;
    }
    public void UpdateUI()
    {

        while (skillCoolDown._currentSkills.Count > skillParent.transform.childCount)
        {
            AddRow();
        }
        
        skillRows = skillParent.GetComponentsInChildren<SkillRow>();
        for (int i = 0; i < skillRows.Length; i++)
        {
            skillRows[i].slot.AddSkill(skillCoolDown._currentSkills[i]);
            skillRows[i].slot.slotIndex = i;
        }

    }

    public void ChangeSkill()
    {
        if (selectedSlot!=null && currentSlot != null)
        {
            (SkillCoolDown.instance._currentSkills[currentSlot.slotIndex],
                skillCoolDown._currentSkills[selectedSlot.slotIndex]) = (
                skillCoolDown._currentSkills[selectedSlot.slotIndex],
                SkillCoolDown.instance._currentSkills[currentSlot.slotIndex]);
        }

        SkillCoolDown.instance.onSkillChangeCallBack.Invoke();
        onSkillUseChangeCallBack.Invoke();
    }
    private void AddRow()
    {
        var slot = Instantiate(skillRowPrefab);
        slot.GetComponent<SkillRow>().index = 0;
        slot.transform.parent = skillParent.transform;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
