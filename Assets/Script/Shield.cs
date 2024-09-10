using DG.Tweening;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public int count;
    public bool enabledShield;
    private MerchantTutorial merchantTutorial;
    // Start is called before the first frame update
    void Start()
    {
        merchantTutorial=GetComponentInParent<MerchantTutorial>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider") && enabledShield)
        {
            count++;
            transform.DOScale(new Vector3(2f, 2f, 2f), .1f).OnComplete(() =>
            {
                transform.DOScale(new Vector3(2.5f, 2.5f, 2.5f), .1f);
            });
            if (count>4)
            {
                merchantTutorial.ShieldBroken();
                Destroy(gameObject);
            }
        }
    }
}
