using System;
using DamageNumbersPro;
using UnityEngine;
using DG.Tweening;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;
    public Stat armor;
    public DamageNumber prefab;
    private SkinnedMeshRenderer[] _skinnedMeshRenderers;
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
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        DamageVFX(damage);
        Debug.Log(transform.name + "takes " + damage + "damage.");
        transform.GetChild(0).DOScale(new Vector3(1.5f, 1.5f, 1.5f), .1f).OnComplete(() =>
        {
            transform.GetChild(0).DOScale(new Vector3(1f, 1f, 1f), .1f);
        });
        for (int i = 0; i < _skinnedMeshRenderers.Length; i++)
        {
            int index = i;
            _skinnedMeshRenderers[i].material.DOColor(Color.red, .1f).SetEase(Ease.Linear)
                .OnComplete((() => _skinnedMeshRenderers[index].material.DOColor(Color.white, .1f).SetEase(Ease.Linear)));
        }
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void DamageVFX(int damage)
    {
        DamageNumber newDamageNumber =
            prefab.Spawn(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                damage);
        prefab.followedTarget = transform;
    }

    public virtual void Die()
    {
        
    }
}