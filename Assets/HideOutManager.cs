using UnityEngine;
using UnityEngine.UI;

public class HideOutManager : MonoBehaviour
{
    public Button hideOutBuildBtn;
    public DoTweenAnimationController[] stones;
    void Start()
    {
        hideOutBuildBtn.onClick.AddListener(BuildBase);
    }

    public void BuildBase()
    {
        for (int i = 0; i < stones.Length; i++)
        {
            stones[i].gameObject.SetActive(true);
            stones[i].StartMove(0.1f*i);
        }
    }
  
}
