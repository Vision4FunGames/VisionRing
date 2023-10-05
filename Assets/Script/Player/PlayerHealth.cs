using UnityEngine;
using DG.Tweening;
using DamageNumbersPro;
using NaughtyAttributes;

public class PlayerHealth : CharacterHealth
{
    public Material _playerMaterial;
    public GameObject _damageNumbersPro;

    private void Awake()
    {
        health = 100;
        _playerMaterial = Resources.Load("PlayerMaterial/boy1") as Material;
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
    }

    [Button("Damage")]
    public void DamageAnimation()
    {
        TakeDamage(10);
        DamageText();
        _playerMaterial.DOColor(Color.red, .05f).SetEase(Ease.Linear).OnComplete(() =>
        {
            _playerMaterial.DOColor(Color.white, .05f).SetEase(Ease.Linear);
        });
    }

    public void DamageText()
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                10);
    }
}