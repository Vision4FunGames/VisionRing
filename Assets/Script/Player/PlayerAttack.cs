using UnityEngine;
using UnityEngine.Serialization;

public enum CurrentGunType
{
    sword,
    arrow,
    spear
}

public class PlayerAttack : MonoBehaviour
{
    public ParticleSystem[] swordParticle;
    public int damage;
    private CurrentGunType myCurrentGunType;
    private Player player;
    private Animator playerAnimator;
    private SwordAttack swordAttack;
    private ArrowAttack arrowAttack;

    [Header("Skills")] 
    public float tornadoDamageRate;
    public int tornadoDamage;
    public int flameDamage;
    public float flameDamageRateOfFire;
    public int earthSkillDamage;

    // Start is called before the first frame update
    void Start()
    {
        myCurrentGunType = CurrentGunType.sword;
        player = FindObjectOfType<Player>();
        playerAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }

    public void Attack()
    {
        switch (myCurrentGunType)
        {
            case CurrentGunType.sword:
                swordAttack ??= playerAnimator.gameObject.AddComponent<SwordAttack>();
                swordAttack.AttackSword(player, playerAnimator);
                break;
            case CurrentGunType.arrow:
                arrowAttack ??= playerAnimator.gameObject.AddComponent<ArrowAttack>();
                arrowAttack.AttackArrow(player, playerAnimator);
                break;
            case CurrentGunType.spear:
                break;
        }
    }

    public void ChangeGunType(CurrentGunType currentGunType)
    {
        myCurrentGunType = currentGunType;
    }
}


public class SwordAttack : MonoBehaviour
{
    private ParticleSystem[] _swordParticle;
    public int comboCounter;
    private float comboTimer;
    [SerializeField] private string comboAttackStringAnimation = "Attack1";
    private Animator playerAnimator;
    private BoxCollider swordCollider;

    private void Start()
    {
        playerAnimator ??= FindObjectOfType<Player>().GetComponentInChildren<Animator>();
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
        swordCollider.size = new Vector3(10, 2, 10);
        swordCollider.center = new Vector3(0, 0, 5);
        swordCollider.enabled = false;
        swordCollider.tag = "SwordCollider";
        swordCollider.isTrigger = true;
    }

    public void EnableSwordCollider()
    {
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
        if (playerAnimator.GetComponentInParent<Player>().speed < 5)
        {
            playerAnimator.GetComponentInParent<Player>().speed *= 2;
            playerAnimator.GetComponentInParent<Player>().animValue *= 2;
        }
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
    private Player player;
    private Animator playerAnimator;
    private bool attack;

    private void Start()
    {
        player ??= FindObjectOfType<Player>();
        playerAnimator ??= FindObjectOfType<Player>().GetComponentInChildren<Animator>();
    }

    public void AttackArrow(Player player, Animator _playerAnimator)
    {
        if (!attack)
        {
            attack = true;
            player.speed /= 2;
            player.animValue /= 2;
            if (Mathf.Abs(player._fixedJoystick.Horizontal + player._fixedJoystick.Vertical) != 0) // yürürken Attack
            {
                _playerAnimator.Play("Arrow", 2, 0);
            }

            if (Mathf.Abs(player._fixedJoystick.Horizontal + player._fixedJoystick.Vertical) == 0) // yürürken Attack
            {
                _playerAnimator.Play("Arrow", 1, 0);
            }
        }
    }

    public void EndAttack()
    {
        attack = false;
        player.speed *= 2;
        player.animValue *= 2;
    }
}