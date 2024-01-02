using System.Collections;
using UnityEngine;
using DG.Tweening;

public class TntObject : MonoBehaviour
{
    public ParticleSystem startParticle;
    public ParticleSystem explosionParticle;
    public GameObject circleParentObj;
    private bool hit;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            Hit();
        }
    }

    public void Hit()
    {
        if (!hit)
        {
            startParticle.Play();
            hit = true;
            circleParentObj.SetActive(true);
            circleParentObj.transform.GetChild(1).transform.localScale = new Vector3(0, 0, 0);
            circleParentObj.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 4f)
                .OnComplete(() =>
                {
                    explosionParticle.Play();
                    Destroy(gameObject,.2f);
                });
        }
        else
        {
            explosionParticle.Play();
            Destroy(gameObject);
        }
    }

    IEnumerator Counter()
    {
        yield return new WaitForSeconds(4f);
        explosionParticle.Play();
        Destroy(gameObject,.5f);
    }

  

}
