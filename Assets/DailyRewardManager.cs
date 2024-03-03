using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardManager : MonoBehaviour
{
    public Image currentReward;
    public Image selector;
    public Image[] imageArray; // Canvas'teki Image nesnelerini içeren dizi
    private int currentIndex = 0; // Şu anki index
    public float delayTime = 0.1f; // Her bir Image arasındaki bekleme süresi
    public float maxDelayTime = .3f; // Maksimum bekleme süresi

    void Start()
    {
        
    }

    public void Collect()
    {
        StartCoroutine(MoveThroughArray());
    }
    IEnumerator MoveThroughArray()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayTime);
            currentIndex = (currentIndex + 1) % imageArray.Length;
            selector.transform.SetParent(imageArray[currentIndex].transform);
            selector.transform.localPosition = Vector3.zero;
            delayTime = Mathf.Lerp(delayTime, maxDelayTime, 0.01f);
            if (delayTime > maxDelayTime - 0.3f)
            {
                currentReward.gameObject.SetActive(true);
                break;
            }
        }
    }
}