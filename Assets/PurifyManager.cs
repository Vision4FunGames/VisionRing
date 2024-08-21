using UnityEngine;

public class PurifyManager : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<Purify>().transform.SetParent(transform);
        FindObjectOfType<Purify>().StartPurify();
    }
}
