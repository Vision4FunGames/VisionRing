using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private Player player;
    private bool Isrope;
    private GameObject currentRope;
    private CameraShake _cameraShake;
    private ParticleSystem _damageParticle;
    [HideInInspector] public GameObject sessizImage;
    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        player = GetComponent<Player>();
        instance = this;
        _damageParticle = Instantiate(Resources.Load("ShadowExplosion", typeof(ParticleSystem)) as ParticleSystem,
            new Vector3(0, 2, 0), Quaternion.identity, transform);
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

    public void CameraShakePlayer(float duration, float magnitude)
    {
        StartCoroutine(_cameraShake.ShakeVector(duration, magnitude));
    }

    public void CameraShakeCombo(float duration, float magnitude)
    {
        StartCoroutine(_cameraShake.Shake(.1f, magnitude * 3));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rope"))
        {
            currentRope = other.gameObject;
            Isrope = true;
            RopeStart();
        }

        if (other.CompareTag("Bush"))
        {
            player.speed = player.baseSpeed / 2;
            player._playerAnimator.SetBool("yurumeBool", true);
            sessizImage = Instantiate(Resources.Load("SessizImage"),GameObject.FindWithTag("mainCanvas").transform)as GameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bush"))
        {
            player.speed = player.baseSpeed;
            player._playerAnimator.SetBool("yurumeBool", false);
            Destroy(sessizImage.gameObject);
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
        currentRope.GetComponent<RopeManager>().fakePlayer.transform.GetChild(0).localScale =
            new Vector3(100, 100, 100);
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