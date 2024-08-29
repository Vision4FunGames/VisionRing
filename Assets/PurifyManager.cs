using UnityEngine;

public class PurifyManager : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<Purify>().transform.SetParent(transform);
        Invoke("StartPurify", 0.5f);
    }

    public void StartPurify()
    {
        FindObjectOfType<Purify>().StartPurify();
    }
}