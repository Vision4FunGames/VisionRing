using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DailyWheelBase : MonoBehaviour
{
    public GameObject canvasWheel;
    public GameObject taskPopup;
    public Button equipSword;
    public Equipment swordMap1;

    private void Start()
    {
        
        equipSword.onClick.AddListener(EquipSwordMap);
    }

    public void EquipSwordMap()
    {
        EquipmentManager.instance.Equip(swordMap1);
        canvasWheel.SetActive(false);
        taskPopup.SetActive(false);
        FindObjectOfType<TaskPrefab>().isCompleted = true;
        Destroy(FindObjectOfType<TaskPrefab>().gameObject);
    }
    public void Result(Reward action)
    {
        taskPopup.transform.DOScale(Vector3.one, 1);
    }
    private void OnMouseDown()
    {
        canvasWheel.SetActive(true);
        GetComponent<Waypoint_Indicator>().enabled = false;
        GetComponentInChildren<IapBundleManager>().ShowLuckySpin(RewardPackType.Map1, 5, Result);
    }
}