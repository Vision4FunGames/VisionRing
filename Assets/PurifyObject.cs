using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PurifyObject : MonoBehaviour
{
    private Purify _purify;
    public int hitCount;

    private void Awake()
    {
        _purify = GetComponentInParent<Purify>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            ParticleSystem c = Instantiate(ParticleManager.instance.purifyParticle);
            c.transform.position = transform.position + new Vector3(0, 1, 0);
            c.Play();
            if (GetComponent<GrowTween>())
            {
                GetComponent<Outline>().enabled = false;
                GetComponent<GrowTween>().Grow();
                if (hitCount > 2)
                {
                    _purify.DestroyObj();
                    Destroy(gameObject);
                }
              
            }
            else
            {
                if (hitCount < 1)
                {
                    Vector3 curScale = new Vector3(transform.parent.transform.localScale.x * 0.75f,
                        transform.parent.transform.localScale.y * 0.75f,
                        transform.parent.transform.localScale.x * 0.75f);
                    transform.parent.DOScale(curScale, .25f).SetEase(Ease.InBack);
                }
                else
                {
                    _purify.DestroyObj();
                    transform.parent.DOScale(Vector3.zero, .25f).SetEase(Ease.InBack)
                        .OnComplete((() => Destroy(transform.parent.gameObject)));
                }

                hitCount++;
            }
        }
    }
}