using DG.Tweening;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            count++;
            transform.DOScale(new Vector3(2f, 2f, 2f), .1f).OnComplete(() =>
            {
                transform.DOScale(new Vector3(2.5f, 2.5f, 2.5f), .1f);
            });
            if (count>4)
            {
                
            }
        }
    }
}
