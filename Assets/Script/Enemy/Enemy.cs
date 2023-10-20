using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{
    #region Variables
    
    private float health;

    private PlayerManager playerManager;
    private CharacterStats myStats;
    #endregion

    private void Start()
    {
        playerManager = PlayerManager.instance;
        myStats = GetComponent<CharacterStats>();
    }

    public override void Interact()
    {
        base.Interact();
        CharacterCombat playerCombat = playerManager.GetComponent<CharacterCombat>();
        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
    }

    public void DoJumpBack(GameObject dir,int damage)
    {
        myStats.TakeDamage(damage);
        Vector3 direction = transform.position - dir.transform.position;
        direction = new Vector3(direction.x, 0, direction.z);
        transform.DOKill();
        transform.DOJump(direction * 5, 2, 1, 1).OnComplete((() => transform.GetChild(0).GetComponent<Collider>().enabled=true));
    }

}
