using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = 2)]
public class Item : ScriptableObject
{
    public ObjectType _objectType;
    public GameObject prefab;
    public int id;
    public string name = "New ScriptableObject";
    public Sprite objectImage;
    public int BuyPrice,SellPrice;
    public enum ObjectType
    {
        Armor,
        Helmet,
        Shoes,
        LeftHand,
        Sword,
        Arrow,
        Spear,
        Upgrade
    }
}