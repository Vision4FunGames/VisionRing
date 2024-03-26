using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using DG.Tweening;

public class TntObject : MonoBehaviour
{
    public ParticleSystem startParticle;
    public ParticleSystem explosionParticle;
    public GameObject circleParentObj;
    private bool hit;
    public List<GameObject> varilList;
    public CameraShake camShake;

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
            DamageAnimation();
            hit = true;
            circleParentObj.SetActive(true);
            circleParentObj.transform.GetChild(1).transform.localScale = new Vector3(0, 0, 0);
            circleParentObj.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 4f)
                .OnComplete(() =>
                {
                    explosionParticle.Play();
                    BrokeTheVarils();
                    GetComponent<MeshRenderer>().enabled = false;
                    startParticle.gameObject.SetActive(false);
                    circleParentObj.gameObject.SetActive(false);
                    camShake.ShakeCam(.1f,5f);
                   
                });
            Destroy(transform.parent.gameObject,8f);
        }
    }

    public void BrokeTheVarils()
    {
        for (int i = 0; i < varilList.Count; i++)
        {
            if (varilList[i].gameObject != null)
            {
                varilList[i].GetComponent<FragileObject>().BrokeTheObject();
            }
        }
    }
    private void DamageAnimation()
    {
        var mesh = GetComponent<MeshRenderer>();
        transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 4f).OnComplete(() =>
        {
                transform.DOScale(new Vector3(1f, 1f, 1f), .3f); 
        });
    }

    IEnumerator Counter()
    {
        yield return new WaitForSeconds(4f);
        explosionParticle.Play();
        Destroy(gameObject,.5f);
    }

  

}
