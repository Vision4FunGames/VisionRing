using System;
using DamageNumbersPro;
using UnityEngine;
using DG.Tweening;
using MoreMountains.Tools;
using PixelCrushers.QuestMachine;

public class CharacterStats : MonoBehaviour
{
    public bool die;
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;
    public Stat armor;
    public DamageNumber prefab;
    public DamageNumber critDamageText;
    private SkinnedMeshRenderer[] _skinnedMeshRenderers;
    public MMProgressBar mmProgressBar;
    public string message;


    private void Awake()
    {
        currentHealth = maxHealth;
        _skinnedMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth > 0 && !die)
        {
            damage -= armor.GetValue();
            damage = Mathf.Clamp(damage, 0, int.MaxValue);
            currentHealth -= damage;
            DamageVFX(damage);
            DamageAnimation();
            UpdateHealthBar();
        }
        else if (currentHealth <= 0)
        {
            Die();
            die = true;
        }
    }

    public void TakeDamage(int damage, bool crit)
    {
        if (currentHealth > 0 && !die)
        {
            damage -= armor.GetValue();
            damage = Mathf.Clamp(damage, 0, int.MaxValue);
            currentHealth -= damage;
            if (crit)
            {
                DamageCritVFX(damage);
            }
            else
            {
                DamageVFX(damage);    
            }
            DamageAnimation();
            UpdateHealthBar();
        }
        else if (currentHealth <= 0)
        {
            Die();
            die = true;
        } 
    }

    public void DamageAnimation()
    {
        transform.GetChild(0).DOScale(new Vector3(1.5f, 1.5f, 1.5f), .1f).OnComplete(() =>
        {
            transform.GetChild(0).DOScale(new Vector3(1f, 1f, 1f), .1f);
        });
        for (int i = 0; i < _skinnedMeshRenderers.Length; i++)
        {
            int index = i;
            _skinnedMeshRenderers[i].material.DOColor(Color.red, .1f).SetEase(Ease.Linear)
                .OnComplete((() =>
                    _skinnedMeshRenderers[index].material.DOColor(Color.white, .1f).SetEase(Ease.Linear)));
        }
    }

    public void DamageVFX(int damage)
    {
        DamageNumber newDamageNumber =
            prefab.Spawn(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                damage);
        newDamageNumber.followedTarget = transform;
    }

    public void DamageCritVFX(int damage)
    {
        DamageNumber newDamageNumber = critDamageText.Spawn(new Vector3(transform.position.x, transform.position.y, transform.position.z),
            damage);
        newDamageNumber.followedTarget = transform;
    }
    
    public virtual void Die()
    {
        QuestMachineMessages.SendCompositeMessage(this, message);
    }

    public void UpdateHealthBar()
    {
        mmProgressBar.UpdateBar(currentHealth, 0, 100);
    }
}