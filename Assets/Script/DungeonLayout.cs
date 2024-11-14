using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DungeonLayout : MonoBehaviour
{
    public GameObject complete;
    public Button buyBtn;
    public TextMeshProUGUI dundeonName;
    public TextMeshProUGUI price;

    private void Start()
    {
        buyBtn.onClick.AddListener(BuyKey);
    }

    public void BuyKey()
    {
        GetComponentInParent<TeleportManager>().BuyKeyDungeon(this);
    }
}
