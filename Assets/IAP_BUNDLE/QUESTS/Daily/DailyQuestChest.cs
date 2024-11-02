using AllIn1SpringsToolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyQuestChest : MonoBehaviour
{
    public GameObject closeImage, openedImage;
    public int requirementStar;
    public bool isOpened;
    public TransformSpringComponent spring;
    public bool isOpenable;
    private void OnEnable()
    {

    }
    public void OpenChest()
    {
        if (isOpened)
        {
            spring.AddVelocityScale(Vector3.one * 5f);
            spring.AddVelocityRotation(Vector3.right * 3f);
        }
        else
        {
            if (isOpenable)
            {
                isOpenable = false;
                Debug.Log("Sandýk Açýldý");
                spring.AddVelocityPosition(Vector3.one * 10f);
                spring.AddVelocityScale(Vector3.right * 5f);
                PlayerPrefs.SetInt("IapBundle_DailyChest" + requirementStar, 1);
                Control();
            }
        }
    }

    public void Clear()
    {
        PlayerPrefs.SetInt("IapBundle_DailyChest" + requirementStar, 0);
    }

    public void Control()
    {
        isOpened = PlayerPrefs.GetInt("IapBundle_DailyChest" + requirementStar) == 1 ? true : false;
        closeImage.SetActive(!isOpened);
        openedImage.SetActive(isOpened);
        if (!isOpenable && !isOpened && DailyQuestManager.Instance.dailyStarCount >= requirementStar)
        {
            isOpenable = true;
            StartCoroutine(Idle());
        }
    }
    private IEnumerator Idle()
    {
        yield return new WaitForSeconds(0.5f);
        while (isOpenable)
        {
            spring.AddVelocityPosition(Vector3.one * 5f);
            spring.AddVelocityScale(Vector3.right * 5f);
            yield return new WaitForSeconds(3f);
        }
    }
}
