using System;
using DamageNumbersPro;
using UnityEngine;
using DG.Tweening;
using MoreMountains.Tools;
using PixelCrushers.QuestMachine;
using Random = System.Random;

public class CharacterStats : MonoBehaviour
{
    public bool die;
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;
    public Stat armor;
    public DamageNumber prefab, critPrefab;
    private SkinnedMeshRenderer[] _skinnedMeshRenderers;
    public MMProgressBar mmProgressBar;
    public string message;
    public event System.Action OnDie;

    private void Awake()
    {
        currentHealth = maxHealth;
        _skinnedMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
        critPrefab = Resources.Load<DamageNumber>("CritSpreadUp");
        OnDie += Die;
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
            DamageVFX(damage, false);
            DamageAnimation();
            UpdateHealthBar();
        }
        else if (currentHealth <= 0)
        {
            Die();
            die = true;
        }
    }

    public void TakeDamage(int damage, float critChance)
    {
        bool crit = false;
        int rnd = UnityEngine.Random.Range(0, 10);
        if (rnd <= critChance * 100)
        {
            crit = true;
        }

        if (currentHealth > 0 && !die)
        {
            damage -= armor.GetValue();
            if (crit)
            {
                damage *= 2;
                DamageVFX(damage, true);
            }
            else
            {
                DamageVFX(damage, false);
            }

            //damage = Mathf.Clamp(damage, 0, int.MaxValue);
            currentHealth -= damage;

            DamageAnimation();
            UpdateHealthBar();
        }
        else if (currentHealth <= 0)
        {
            Die();
            die = true;
        }
    }

    public void CalculateCriticalChance()
    {
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

    public void DamageVFX(int damage, bool crit)
    {
        if (!crit)
        {
            DamageNumber newDamageNumber =
                prefab.Spawn(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                    damage);
            newDamageNumber.followedTarget = transform;
        }
        else
        {
            DamageNumber newDamageNumber =
                critPrefab.Spawn(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                    damage);
            newDamageNumber.followedTarget = transform;
        }
    }


    public virtual void Die()
    {
        QuestMachineMessages.SendCompositeMessage(this, message);
    }

    public void UpdateHealthBar()
    {
        if (mmProgressBar)
            mmProgressBar.UpdateBar(currentHealth, 0, 100);
    }
}