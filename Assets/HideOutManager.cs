using UnityEngine;
using UnityEngine.UI;

public class HideOutManager : MonoBehaviour
{
    public GameObject canvas;
    public Button hideOutBuildBtn;
    public DoTweenAnimationController[] stones;
    void Start()
    {
        hideOutBuildBtn.onClick.AddListener(BuildBase);
        BuildAlreadyBase();
    }

    public void BuildAlreadyBase()
    {
        canvas.SetActive(false);
        for (int i = 0; i < stones.Length; i++)
        {
            stones[i].gameObject.SetActive(true);
            stones[i].transform.localPosition = new Vector3(stones[i].transform.position.x, 0, stones[i].transform.position.z);
        }
    }

    public void BuildBase()
    {
        canvas.SetActive(false);
        for (int i = 0; i < stones.Length; i++)
        {
            stones[i].gameObject.SetActive(true);
            stones[i].StartMove(0.05f*i);
        }
    }
}
