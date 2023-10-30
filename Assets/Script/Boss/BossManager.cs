using System;
using DamageNumbersPro;
using MoreMountains.Tools;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    private float bossBaseHealth;
    private bool bossSpecialSkelet;
    private Canvas mainCanvas;
    private BossMovement bossMovement;
    private bool sleep;
    private Player player;
    public ParticleSystem stunParticle;
    private bool isStunned;
    public float bossHealth;
    [HideInInspector] public GameObject _damageNumbersPro;
    public MMProgressBar mmProgressBar;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
        bossMovement = GetComponent<BossMovement>();
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
        mainCanvas = GameObject.FindWithTag("mainCanvas").GetComponent<Canvas>();
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 40 && !sleep)
        {
            WakeUp();
        }
    }

    public void WakeUp()
    {
        sleep = true;
        bossMovement.navMeshAgent.enabled = true;
        mmProgressBar.gameObject.SetActive(true);
    }
    public void BossTakeSwordDamage(int damage)
    {
        if (bossHealth > 0)
        {
            if (isStunned)
            {
                bossHealth -= damage;
                ShowDamageText(damage*100);
                mmProgressBar.UpdateBar(bossHealth,0,100);
            }
            else
            {
                bossHealth -= (damage / 10);
                ShowDamageText(damage*10);
                mmProgressBar.UpdateBar(bossHealth,0,100);
            }
        }
        
    }

    public void CheckBossHealth()
    {
        if (bossHealth < bossBaseHealth / 2 && !bossSpecialSkelet)
        {
            
        }
    }

    public void ShowDamageText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                damage);
    }
}
