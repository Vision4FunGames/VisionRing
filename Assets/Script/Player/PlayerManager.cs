using System;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private PlayerAttack _playerAttack;
    private PlayerHealth _playerHealth;
    private Player player;
    private bool Isrope;
    private GameObject currentRope;
    private CameraShake _cameraShake;
    private ParticleSystem _damageParticle;
    [HideInInspector] public GameObject sessizImage;
    private float currentTime, delayTime = 2;
    public bool edit;
    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        Vector3 startPlayerPos = ES3.Load("CheckPoint", transform.position) + new Vector3(0,0,-4);
        if(!edit)
            transform.position = startPlayerPos;
        _playerAttack = GetComponent<PlayerAttack>();
        _playerHealth = GetComponent<PlayerHealth>();
        player = GetComponent<Player>();
        instance = this;
        _damageParticle = Instantiate(Resources.Load("ShadowExplosion2", typeof(ParticleSystem)) as ParticleSystem,
            new Vector3(0, 2, 0), Quaternion.identity, transform);
        _damageParticle.transform.localPosition = new Vector3(0, 2, 0);
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
            sessizImage =
                Instantiate(Resources.Load("SessizImage"),
                    GameObject.FindWithTag("mainCanvas").transform) as GameObject;
        }

        if (other.CompareTag("CheckPoint"))
        {
            other.GetComponent<CheckPoint>().healParticle.Play();
            other.GetComponent<CheckPoint>().campFireParticle.Play();
            other.GetComponent<CheckPoint>().shineParticle.Stop();
            ES3.Save("CheckPoint", other.transform.position);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            currentTime += Time.deltaTime;
            if (currentTime > delayTime)
            {
                currentTime = 0;
                _playerHealth.DamageAnimation(2);
            }
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
        if (other.CompareTag("CheckPoint"))
        {
            other.GetComponent<CheckPoint>().healParticle.Stop();
            other.GetComponent<CheckPoint>().campFireParticle.Stop();
            other.GetComponent<CheckPoint>().shineParticle.Play();
       
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

    public void Stun(GameObject enemy)
    {
        _playerAttack.isStun = true;
        player.isMovement = false;
        player.speed = 0;
        player.rotSpeed = 0;
        Vector3 target = transform.position - enemy.transform.position;
        target = new Vector3(target.x, 0, target.z);
        print(target);
        transform.DOMove(player.transform.position + (target * 2), 1f);
        CancelInvoke("DisableStun");
        Invoke("DisableStun", 2);
        player._playerAnimator.Play("Dusme");
    }

    public void DisableStun()
    {
        _playerAttack.isStun =false;
        player.isMovement = true;
        player.speed = player.baseSpeed;
        player.rotSpeed = 5;
    }
}