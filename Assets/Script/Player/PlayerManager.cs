using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private bool Isrope;
    private GameObject currentRope;
    private CameraShake _cameraShake;
    private ParticleSystem _damageParticle;
    #region Singleton

    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
        _damageParticle = Instantiate(Resources.Load("ShadowExplosion", typeof(ParticleSystem))as ParticleSystem,new Vector3(0,2,0), Quaternion.identity,transform);
        _cameraShake = FindObjectOfType<CameraShake>();
    }


    #endregion

    public void KillPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void DamageHitParticle()
    {
        _damageParticle.Play();
    }

    public void CameraShakePlayer(float duration , float magnitude)
    {
        StartCoroutine(_cameraShake.ShakeVector(duration, magnitude));
    }

    public void CameraShakeCombo(float duration , float magnitude)
    {
        StartCoroutine(_cameraShake.Shake(.1f, magnitude*3));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rope"))
        {
            currentRope = other.gameObject;
            Isrope = true;
            RopeStart();
        }
    }

    private void Update()
    {
        if (Isrope && Input.GetKeyDown(KeyCode.Space))
        {
            RopeFinish();
        }
    }

    public void RopeStart()
    {
      
        transform.GetComponent<CharacterController>().enabled = false;
        currentRope.GetComponent<RopeManager>().fakePlayer.transform.GetChild(0).localScale = new Vector3(100, 100, 100);
        currentRope.GetComponent<Collider>().enabled = false;
        transform.localScale = new Vector3(0, 0, 0);
        transform.SetParent(currentRope.GetComponent<RopeManager>().fakePlayer.transform.GetChild(0).GetChild(0));
        transform.localPosition = Vector3.zero;
    }

    public void RopeFinish()
    {
        Isrope = false;
        transform.SetParent(null);
        transform.localScale = new Vector3(1, 1, 1);
        transform.GetComponent<CharacterController>().enabled = true;
        currentRope.GetComponent<RopeManager>().fakePlayer.transform.GetChild(0).localScale = new Vector3(0, 0, 0);
        currentRope.GetComponent<Collider>().enabled = true;
       
    }
}
