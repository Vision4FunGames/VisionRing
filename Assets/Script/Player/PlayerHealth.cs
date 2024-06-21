using System;
using System.Collections;
using AmazingAssets.DynamicRadialMasks;
using UnityEngine;
using DamageNumbersPro;
using DG.Tweening;
using Exoa.TutorialEngine;
using MapMinimap;
using MoreMountains.Tools;
using Unity.VisualScripting;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PlayerHealth : CharacterHealth
{
    private DRMGameObject drmGameObject;
    Material _playerMaterial;
    [HideInInspector] public GameObject _damageNumbersPro;
    private bool isCooldown;

    [Header("Heal Buff")] public float healRate;
    public GameObject healBuffParticle;
    public float healTime;
    public bool firstHeal;
    public float healCooldown;
    private bool isHealBuff;
    private float newHealth;
    private float maxHealth;
    public int HealLimit { get; set; } = 3;

    private void Awake()
    {
        _player = GetComponent<Player>();
        drmGameObject = GetComponentInChildren<DRMGameObject>();
        health = 300;
        maxHealth = health;
        _playerMaterial = Resources.Load("PlayerMaterial/boy1") as Material;
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
        mmProgressBar = FindObjectOfType<Minimap>().GetComponentInChildren<MMProgressBar>();
        _gameManager = FindObjectOfType<GameManager>();
        mmProgressBar.LerpForegroundBarDurationIncreasing = 3f;
    }
    private void Start()
    {
        UiManager.instance.healText.text = HealLimit.ToString();
    }

    private void Update()
    {
        if (isHealBuff)
        {
            healTime -= Time.deltaTime;

            if (healTime <= 0)
            {
                isHealBuff = false;
                healBuffParticle.gameObject.SetActive(false);
            }
        }

        if (isCooldown)
        {
            healCooldown -= Time.deltaTime;
            if (healCooldown <= 0)
            {
                healCooldown = 0;
                isCooldown = false;
            }
        }
        if (Input.GetKey(KeyCode.K))
        {
            DamageText(10);
        }
    }

    public void DamageAnimation(int damage)
    {
        if (!useShield && GameManager.instance.gameState != GameState.Pause)
        {
            GameManager.instance.PlayFightSound();
            drmGameObject.timer = 0;
                _player.playerSound.hitSource.PlayOneShot(_player.playerSound.hitMeSound[Random.Range(0,2)]);
            TakeDamage(damage);
            DamageText(damage);
            PlayerManager.instance.DamageHitParticle();
        }
    }

    public void DamageText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.localPosition.x, transform.localPosition.y + 2f, transform.localPosition.z),
                damage);
        newDamageNumber.transform.localScale = new Vector3(2, 2, 2);
        newDamageNumber.followedTarget = transform;
    }
   
    #region HealBuff

    public void EnableHealBuff(GameObject btn)
    {
        if (health < maxHealth && !isCooldown && HealLimit > 0)
        {
            HealLimit--;
            UiManager.instance.healText.text = HealLimit.ToString();
            healCooldown = 8f;
            isCooldown = true;
            healRate = .3f;
            HealBuff(true);
            HealBtnCoolDown(btn);
        }
    }

    public void EnableHealBuff(bool isArea)
    {
        if (health < maxHealth && !isCooldown && HealLimit > 0)
        {
            HealLimit--;
            UiManager.instance.healText.text = HealLimit.ToString();
            if (isArea)
            {
                healCooldown = 1f;
                healRate = 5f;
            }
            else
            {
                healCooldown = 8f;
                healRate = .3f;
            }
            isCooldown = true;
            HealBuff(true);
        }
    }


    public void HealBuff(bool isFirst)
    {
        isHealBuff = true;
        healTime = 3f;
        healBuffParticle.gameObject.SetActive(true);
        health +=  ((maxHealth *.6f) * healRate);
        mmProgressBar.UpdateBar(health, 0, maxHealth);
        if (health > maxHealth)
            health = maxHealth;
    }

    public void HealBtnCoolDown(GameObject btn)
    {
        
        var btnImage = btn.GetComponent<Image>();
        btnImage.fillAmount = 0f;
        btnImage.DOFillAmount(360f, 8f).SetEase(Ease.Linear);

        var btnFill = btn.transform.GetChild(2);
        for (int i = 0; i < btnFill.transform.childCount; i++)
        {
            btnFill.transform.GetChild(i).GetComponent<Image>().fillAmount = 0f;
        }
        FillImage(btnFill,0);
    }

    public void FillImage(Transform t,int child)
    {
        
        t.GetChild(child).GetComponent<Image>().DOFillAmount(1, 2f).SetEase(Ease.Linear).OnComplete(() =>
        {
            if (child <3)
            {
               FillImage(t,child + 1);   
            }
        });
    }

    #endregion
}