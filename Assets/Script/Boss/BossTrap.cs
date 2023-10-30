using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class BossTrap : MonoBehaviour
{
    public ParticleSystem explosion;

    private GameObject[] obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = new GameObject[transform.childCount];
        for (int i = 1; i < transform.childCount; i++)
        {
            obj[i] = transform.GetChild(i).gameObject;
        }
    }

    [Button("Explosion")]
    public void Explosion()
    {
        explosion.Play();
        for (int i = 1; i < obj.Length; i++)
        {
            obj[i].GetComponent<Rigidbody>().isKinematic = false;
            obj[i].GetComponent<Rigidbody>().AddExplosionForce(100, transform.position, 10, 3.0F);
            obj[i].GetComponent<Collider>().isTrigger = false;
        }
        
        StartCoroutine(ExplosionFinish());
    }

    IEnumerator ExplosionFinish()
    {

        yield return new WaitForSeconds(15f);
        // for (int i = 0; i < obj.Length; i++)
        // {
        //     Destroy(obj[i]);
        // }
        Destroy(gameObject);
    }
}