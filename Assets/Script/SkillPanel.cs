using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPanel : MonoBehaviour
{
    private SkillCoolDown skillCoolDown;
    public delegate void onSkillUseChange();
    public onSkillUseChange onSkillUseChangeCallBack;
    public GameObject skillParent;
    public GameObject skillRowPrefab;
    #region Singleton
    public static SkillPanel instance;
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
    }

    public void UpdateUI()
    {

        while (skillCoolDown._currentSkills.Count > skillParent.transform.childCount)
        {
            AddRow();
        }
        
    }

    private void AddRow()
    {
        var slot = Instantiate(skillRowPrefab);
        slot.transform.parent = skillParent.transform;
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
