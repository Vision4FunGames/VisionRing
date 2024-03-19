using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    
    private void Start()
    {
        
    }

    public override void Die()
    {
        base.Die();
        //Kill the Player 
        PlayerManager.instance.KillPlayer();
    }
    public void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {
        if (newItem != null) {
            armor.AddModifier (newItem.armorModifier);
            damage.AddModifier (newItem.damageModifier);
            health.AddModifier(newItem.hpModifier);
            critChance.AddModifier(newItem.critChanceModifier);
        }

        if (oldItem != null)
        {
            armor.RemoveModifier(oldItem.armorModifier);
            damage.RemoveModifier(oldItem.armorModifier);
            health.RemoveModifier(oldItem.hpModifier);
            critChance.RemoveModifier(oldItem.critChanceModifier);
        }

    }
}
