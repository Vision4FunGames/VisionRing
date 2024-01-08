using System;
using System.Collections;
using AmazingAssets.DynamicRadialMasks;
using UnityEngine;
using DamageNumbersPro;
using DG.Tweening;
using MoreMountains.Tools;
using Unity.VisualScripting;
using UnityEngine.UI;

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
    private int healLimit = 3;
    private void Awake()
    {
        _player = GetComponent<Player>();
        drmGameObject = GetComponentInChildren<DRMGameObject>();
        health = 100;
        _playerMaterial = Resources.Load("PlayerMaterial/boy1") as Material;
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
        mmProgressBar = FindObjectOfType<bl_MiniMap>().GetComponentInChildren<MMProgressBar>();
        _gameManager = FindObjectOfType<GameManager>();

    }

    private void Start()
    {
        UiManager.instance.healText.text = healLimit.ToString();
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
    }

    public void DamageAnimation(int damage)
    {
        if (!useShield)
        {
            drmGameObject.timer = 0;
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
        newDamageNumber.followedTarget = transform;
    }
    
    #region HealBuff

    public void EnableHealBuff(GameObject btn)
    {
        if ( health<100f && !isCooldown && healLimit > 0)
        {
            healLimit--;
            UiManager.instance.healText.text = healLimit.ToString();
            healCooldown = 8f;
            isCooldown = true;
            healRate = .3f;
            HealBuff(true);
            HealBtnCoolDown(btn);
        }
    }
    
    
    public void HealBuff(bool isFirst)
    {
        firstHeal = isFirst;
      
        if (firstHeal)
        {
           
            isHealBuff = true;
            healTime = 3f;
            healBuffParticle.gameObject.SetActive(true);
        }
        else
        {
            
            health += (int)(20f*healRate);
            Debug.Log("Health: " + health + " Islem: " + 20 * healRate);
           mmProgressBar.UpdateBar(health, 0, 100);
            if (health >= 100)
            {
                health = 100;
                mmProgressBar.UpdateBar(health, 0, 100);
                DisableHealBuff();
                StopCoroutine(HealCor());
            }
        }
        StartCoroutine(HealCor());
    }
    
    IEnumerator HealCor()
    {
        yield return new WaitForSeconds(.5f);
        if (isHealBuff)
        {
            Debug.Log("HealBuff COr");
            HealBuff(false);
        }
    }
    public void DisableHealBuff()
    {
        healBuffParticle.gameObject.SetActive(false);
        isHealBuff = false;
    }

    public void HealBtnCoolDown(GameObject btn)
    {
        var btnImage = btn.GetComponent<Image>();
        btnImage.fillAmount = 0f;
        btnImage.DOFillAmount(360f, 8f).SetEase(Ease.Linear);
    }
    #endregion    
}