using System;
using System.Collections;
using System.Collections.Generic;
using Script.CombatScript;
using UnityEngine;

public enum CurrentGunType
{
    sword,
    arrow,
    spear
}

public class PlayerAttack : MonoBehaviour
{
    [HideInInspector] public bool isDead, isStun;
    public ParticleSystem[] swordParticle;
    public int damage;
    public float critChance;
    public CurrentArrowType myCurrentArrowType;
    public CurrentGunType myCurrentGunType;
    private Player player;
    private Animator playerAnimator;
    private SwordAttack swordAttack;
    private ArrowAttack arrowAttack;
    public List<GameObject> arrow;
    [Header("Skills")] public float tornadoDamageRate;
    public int tornadoDamage;
    public int flameDamage;
    public float flameDamageRateOfFire;
    public int earthSkillDamage;
    public ParticleSystem flameTFloor;
    public ParticleSystem missAttackParticle;
    private bool hold = false;
    private PlayerStats playerStats;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GetComponent<PlayerStats>();
        playerAnimator = GetComponentInChildren<Animator>();
        for (int i = 0; i < 30; i++)
        {
            arrow.Add(Instantiate(Resources.Load("Arrow") as GameObject));
            arrow[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
            StopCoroutine(Hold());
        }
    }

    public void Attack()
    {
        if (!isDead && !isStun && !player.ring && !player.isSwim && !player.horse)
        {
            switch (myCurrentGunType)
            {
                case CurrentGunType.sword:
                    if (GameManager.instance.tutorialSection ==0 && GameManager.instance.tutorialCounter <= 1)
                    {
                        swordAttack ??= playerAnimator.gameObject.AddComponent<SwordAttack>();
                        swordAttack.AttackSword(player, playerAnimator);
                    }
                    else
                    {
                        swordAttack ??= playerAnimator.gameObject.AddComponent<SwordAttack>();
                        swordAttack.AttackSword(player, playerAnimator);
                    }
                    break;
                case CurrentGunType.arrow:
                    arrowAttack ??= playerAnimator.gameObject.AddComponent<ArrowAttack>();
                    arrowAttack.AttackArrow(player, playerAnimator, myCurrentArrowType);
                    break;
                case CurrentGunType.spear:
                    break;
            }
        }
    }

    public void HoldAttack()
    {
        
        StartCoroutine(Hold());
    }
    public IEnumerator Hold()
    {
        yield return new WaitForSeconds(.25f);
        Attack();
        Debug.Log("Attack ");
        HoldAttack();
    }

    public void StopHoldAttack()
    {
        StopCoroutine(Hold());
        hold = false;
    }
    public void ChangeGunType(CurrentGunType currentGunType)
    {
        myCurrentGunType = currentGunType;
        player._baseCurrentGunType = currentGunType;
    }

    public int CalculateDamage()
    {
        damage = (int)(playerStats.damage.GetValue());
        return damage;
    }
}


public class SwordAttack : MonoBehaviour
{
    private ParticleSystem[] _swordParticle;
    public int comboCounter;
    private float comboTimer;
    [SerializeField] private string comboAttackStringAnimation = "Attack1";
    private Animator playerAnimator;
    private Player player;
    private BoxCollider swordCollider;

    private void Start()
    {
        playerAnimator ??= FindObjectOfType<Player>().GetComponentInChildren<Animator>();
        player = playerAnimator.GetComponentInParent<Player>();
        _swordParticle = Player.instance.GetComponent<PlayerAttack>().swordParticle;
        GenerateSwordCollider();
    }


    private void Update()
    {
        ComboCalculate();
    }

    public void AttackSword(Player player, Animator _playerAnimator)
    {
        if (Mathf.Abs(player._fixedJoystick.Horizontal + player._fixedJoystick.Vertical) != 0 &&
            comboCounter == 0) // yürürken Attack
        {
            comboCounter++;
            _playerAnimator.Play("Attack1", 1, 0);
            if (player.speed > 2.5)
            {
                player.speed /= 2;
                player.animValue /= 2;
            }
        }

        if (Mathf.Abs(player._fixedJoystick.Horizontal + player._fixedJoystick.Vertical) == 0 &&
            comboCounter == 0) // dururken Attack
        {
            comboCounter++;
            _playerAnimator.Play("Attack1", 0, 0);
            if (player.speed > 2.5)
            {
                player.speed /= 2;
                player.animValue /= 2;
            }
        }

        _playerAnimator.SetBool("combo", true);
        comboTimer = 0;
    }

    private void ComboCalculate()
    {
        comboTimer += Time.deltaTime;
        if (comboTimer > .3f)
        {
            comboCounter = 0;
            playerAnimator.SetBool("combo", false);
            comboTimer = 0;
        }
    }

    public void GenerateSwordCollider()
    {
        swordCollider ??= gameObject.AddComponent<BoxCollider>();
        swordCollider.size = new Vector3(5, 2, 5);
        swordCollider.center = new Vector3(0, 0, 2);
        swordCollider.enabled = false;
        swordCollider.tag = "SwordCollider";
        swordCollider.isTrigger = true;
    }

    public void SlowMotion()
    {
        PlayerManager.instance.SlowMotion();
    }
    public void EnableSwordCollider(int attackCount)
    {
       
        player.playerSound.swordAudioSource.PlayOneShot(player.playerSound.swordHitSound[attackCount], .7f);
        swordCollider.enabled = false;
        swordCollider.enabled = true;
    }

    public void ParticleSword(int index)
    {
        
        _swordParticle[index].Play();
        if (index == 2)
        {
          
            PlayerManager.instance.CameraShakePlayer(.4f, 2f);
            PlayerManager.instance.CameraShakeCombo(.6f, .7f);
        }
        else
        {
            PlayerManager.instance.CameraShakePlayer(1f, .9f);
        }
    }

    public void DisableCollider()
    {
        swordCollider.enabled = false;
        playerAnimator.GetComponentInParent<Player>().speed = playerAnimator.GetComponentInParent<Player>().baseSpeed;
        playerAnimator.GetComponentInParent<Player>().animValue = 1;
    }

    public void ComboAttackPlus()
    {
        comboCounter++;
    }

    public void ComboAttackReset()
    {
        
        comboCounter = 0;
        if (playerAnimator.GetComponentInParent<Player>().speed < 5)
        {
            playerAnimator.GetComponentInParent<Player>().speed *= 2;
            playerAnimator.GetComponentInParent<Player>().animValue *= 2;
        }
    }
}

public class ArrowAttack : MonoBehaviour
{
    public Collider[] hitColliders;
    private PlayerAttack playerAttack;
    private Player player;
    private Animator playerAnimator;
    private bool attack;
    public LayerMask layer;
    public CurrentArrowType mycurrentArrowType;
    GameObject closestEnemy;


    private void Start()
    {
        layer = LayerMask.GetMask("Enemy");
        playerAttack ??= FindObjectOfType<PlayerAttack>();
        player ??= FindObjectOfType<Player>();
        playerAnimator ??= FindObjectOfType<Player>().GetComponentInChildren<Animator>();
    }

    public void CheckEnemyNear()
    {
        hitColliders = Physics.OverlapSphere(transform.position, 40, layer);
        float min = 100;
        for (int i = 0; i < hitColliders.Length; i++)
        {
            float currentDistance = Vector3.Distance(transform.position, hitColliders[i].transform.position);
            if (currentDistance < min && !hitColliders[i].GetComponent<EnemyStats>().die)
            {
                closestEnemy = hitColliders[i].gameObject;
                min = currentDistance;
            }
        }
    }

    public void ArrowSpawn()
    {
        if (closestEnemy)
        {
            switch (mycurrentArrowType)
            {
                case CurrentArrowType.single:
                    GameObject currentArrow = playerAttack.arrow[0];
                    currentArrow.transform.position = transform.position + new Vector3(0, 2, 0);
                    currentArrow.SetActive(true);
                    currentArrow.GetComponent<Arrow>().ArrowStart(closestEnemy, false, false, false);
                    ArrowRemove();
                    break;
                case CurrentArrowType.three:
                    GameObject currentArrow2 = playerAttack.arrow[0];
                    currentArrow2.transform.position = transform.position + new Vector3(0, 2, 0);
                    currentArrow2.SetActive(true);
                    ArrowRemove();
                    currentArrow2.GetComponent<Arrow>().ArrowStart(closestEnemy, false, true, false);
                    break;
                case CurrentArrowType.split:
                    GameObject currentArrow1 = playerAttack.arrow[0];
                    currentArrow1.transform.position = transform.position + new Vector3(0, 2, 0);
                    currentArrow1.SetActive(true);
                    currentArrow1.GetComponent<Arrow>().ArrowStart(closestEnemy, true, false, false);
                    ArrowRemove();
                    break;
                case CurrentArrowType.bounce:
                    GameObject currentArrow3 = playerAttack.arrow[0];
                    currentArrow3.transform.position = transform.position + new Vector3(0, 2, 0);
                    currentArrow3.SetActive(true);
                    currentArrow3.GetComponent<Arrow>().ArrowStart(closestEnemy, false, false, true);
                    ArrowRemove();
                    break;
            }
        }
    }

    public void ArrowRemove()
    {
        playerAttack.arrow.RemoveAt(0);
    }

    public void AttackArrow(Player player, Animator _playerAnimator, CurrentArrowType _arrowType)
    {
        mycurrentArrowType = _arrowType;
        if (!attack)
        {
            CheckEnemyNear();
            if (closestEnemy)
            {
                attack = true;
                player.speed /= 2;
                player.animValue /= 2;
                if (Mathf.Abs(player._fixedJoystick.Horizontal + player._fixedJoystick.Vertical) !=
                    0) // yürürken Attack
                {
                    _playerAnimator.Play("Arrow", 1, 0);
                }

                if (Mathf.Abs(player._fixedJoystick.Horizontal + player._fixedJoystick.Vertical) ==
                    0) // yürürken Attack
                {
                    _playerAnimator.Play("Arrow", 0, 0);
                }
            }
        }
    }

    public void EndAttack()
    {
        ArrowSpawn();
        attack = false;
        playerAnimator.GetComponentInParent<Player>().speed = playerAnimator.GetComponentInParent<Player>().baseSpeed;
        playerAnimator.GetComponentInParent<Player>().animValue = 1;
    }
}