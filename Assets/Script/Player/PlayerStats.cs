using Tayx.Graphy.Utils.NumString;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    [Header("Player Bravery")] public int atkMultiplier;
    public int armorMultiplier;
    public int speedMultiplier;
    public int healthMultiplier;
    public int crictChangeMultiplier;

    private void Start()
    {
        CalculateBravery();
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            CalculateBravery();
        }
    }
    public void CalculateBravery()
    {
     
        UiManager.instance.playerBravery.text = StaticFuncs.FormatNumber(TotalBravery());
    }

    public int TotalBravery()
    {
        int totalVal = armorValue * armorMultiplier +
                       damage.GetValue().ToInt() * atkMultiplier +
                       speedMultiplier * Player.instance.speed.ToInt()+
                       health.GetValue().ToInt()*healthMultiplier+
                       crictChangeMultiplier*critChance.GetValue().ToInt();
        return totalVal;
    }
    public override void Die()
    {
        base.Die();
        //Kill the Player 
        PlayerManager.instance.KillPlayer();
    }

    public void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {
        if (newItem != null)
        {
            armor.AddModifier(newItem.armorModifier);
            damage.AddModifier(newItem.damageModifier);
            health.AddModifier(newItem.hpModifier);
            critChance.AddModifier(newItem.critChanceModifier);
        }

        if (oldItem != null)
        {
            armor.RemoveModifier(oldItem.armorModifier);
            damage.RemoveModifier(oldItem.damageModifier);
            health.RemoveModifier(oldItem.hpModifier);
            critChance.RemoveModifier(oldItem.critChanceModifier);
        }
    }
}