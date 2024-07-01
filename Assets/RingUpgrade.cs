using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RingUpgrade : MonoBehaviour
{
    public int currentValuePink, currentValueRed, currentValueBlue;
    public TextMeshProUGUI currentPink, currentBlue, currentRed;
    public GameObject[] blueStonesUpgrade, redStonesUpgrade, pinkStonesUprage;
    public Slider HP, ATK, DEF;


    [Header("_________________________________")]
    public RingSocket blueSocket;

    public RingSocket redSocket;
    public RingSocket pinkSocket;

    [Header("_________________________________")]
    public int HPMinValue;

    public int HPMaxValue;
    public int currentHPval;

    [Header("_________________________________")]
    public int ATKMinValue;

    public int ATKMaxValue;
    public int currentATKVal;

    [Header("_________________________________")]
    public int DEFMinValue;

    public int DEFMaxValue;
    public int currentDEFVal;

    [Header("_________________________________")]
    public Button pinkBtn;

    public TextMeshProUGUI pinkLevelText;
    public TextMeshProUGUI pinkCost;
    private int pinkLevelVal;

    [Header("_________________________________")]
    public Button blueBtn;

    public TextMeshProUGUI blueLevelText;
    public TextMeshProUGUI blueCost;
    private int blueLevelVal;

    [Header("_________________________________")]
    public Button redBtn;

    public TextMeshProUGUI redLevelText;
    public TextMeshProUGUI redCost;
    private int redLevelVal;


    public float hpMulpVal;
    public float atkMulpVal;
    public float defMulpVal;

    private void Start()
    {
        HP.value = 0;
        ATK.value = 0;
        DEF.value = 0;
        CurrentStoneText();
        pinkBtn.onClick.AddListener(BuyPink);
        redBtn.onClick.AddListener(BuyRed);
        blueBtn.onClick.AddListener(BuyBlue);

        hpMulpVal = 1 / ((pinkSocket.HPMultiplier + redSocket.HPMultiplier + blueSocket.HPMultiplier) * (blueSocket.maxLevel-1));
        atkMulpVal = 1 / ((pinkSocket.ATKMultiplier + redSocket.ATKMultiplier + blueSocket.ATKMultiplier) * (blueSocket.maxLevel-1));
        defMulpVal = 1 / ((pinkSocket.DEFMultiplier + redSocket.DEFMultiplier + blueSocket.DEFMultiplier) * (blueSocket.maxLevel-1));
        currentDEFVal = DEFMinValue;
        currentATKVal = ATKMinValue;
        currentHPval = HPMinValue;
    }

    private void OnEnable()
    {
        print("a");
        currentValuePink = EconomyManager.instance.GetStoneCount("DarkStone");
        currentValueRed = EconomyManager.instance.GetStoneCount("LifeStone");
        currentValueBlue = EconomyManager.instance.GetStoneCount("LightStone");


        CurrentStoneText();
    }

    public void BuyPink()
    {
        if (pinkSocket.stoneCost[pinkLevelVal] < currentValuePink && pinkLevelVal + 1 < pinkSocket.stoneCost.Length)
        {
            currentValuePink -= pinkSocket.stoneCost[pinkLevelVal];
            EconomyManager.instance.SetStoneCount("DarkStone", currentValuePink);
            CurrentStoneText();
            pinkLevelVal++;
            pinkLevelText.text = (pinkLevelVal + 1).ToString();
            pinkCost.text = pinkSocket.stoneCost[pinkLevelVal].ToString();
            HP.value += hpMulpVal * pinkSocket.HPMultiplier;
            ATK.value += atkMulpVal * pinkSocket.ATKMultiplier;
            DEF.value += defMulpVal * pinkSocket.DEFMultiplier;
            SetCharacterPower();
        }
    }

    public void BuyRed()
    {
        if (redSocket.stoneCost[redLevelVal] < currentValueRed && redLevelVal + 1 < redSocket.stoneCost.Length)
        {
            currentValueRed -= pinkSocket.stoneCost[redLevelVal];
            EconomyManager.instance.SetStoneCount("LifeStone", currentValueRed);
            CurrentStoneText();
            redLevelVal++;
            redLevelText.text = (redLevelVal + 1).ToString();
            redCost.text = redSocket.stoneCost[redLevelVal].ToString();
            HP.value += hpMulpVal * redSocket.HPMultiplier;
            ATK.value += atkMulpVal * redSocket.ATKMultiplier;
            DEF.value += defMulpVal * redSocket.DEFMultiplier;
            SetCharacterPower();
        }
    }

    public void BuyBlue()
    {
        if (blueSocket.stoneCost[blueLevelVal] < currentValueBlue && blueLevelVal + 1 < blueSocket.stoneCost.Length)
        {
            currentValueBlue -= pinkSocket.stoneCost[blueLevelVal];
            EconomyManager.instance.SetStoneCount("LightStone", currentValueBlue);
            CurrentStoneText();
            blueLevelVal++;
            blueLevelText.text = (blueLevelVal + 1).ToString();
            blueCost.text = blueSocket.stoneCost[blueLevelVal].ToString();
            HP.value += hpMulpVal * blueSocket.HPMultiplier;
            ATK.value += atkMulpVal * blueSocket.ATKMultiplier;
            DEF.value += defMulpVal * blueSocket.DEFMultiplier;
            SetCharacterPower();
        }
    }

    public void SetCharacterPower()
    {
        currentDEFVal = (int)(Mathf.Ceil(DEFMaxValue * DEF.value));
        currentATKVal = (int)(Mathf.Ceil(ATKMaxValue * ATK.value));
        currentHPval = (int)(Mathf.Ceil(HPMaxValue * HP.value));

        Player.instance.GetComponent<PlayerStats>().damage.ZeroIndexRemove();
        Player.instance.GetComponent<PlayerStats>().armor.ZeroIndexRemove();
        Player.instance.GetComponent<PlayerStats>().health.ZeroIndexRemove();
        
        Player.instance.GetComponent<PlayerStats>().armor
            .AddModifier(Player.instance.GetComponent<PlayerStats>().armor.GetValue() + currentDEFVal);
        Player.instance.GetComponent<PlayerStats>().armorValue =
            (int)Player.instance.GetComponent<PlayerStats>().armor.GetValue();
        Player.instance.GetComponent<PlayerStats>().damage
            .AddModifier(Player.instance.GetComponent<PlayerStats>().damage.GetValue() + currentATKVal);
        Player.instance.GetComponent<PlayerStats>().health
            .AddModifier(Player.instance.GetComponent<PlayerStats>().health.GetValue() + currentHPval);
        Player.instance.GetComponent<PlayerStats>().maxHealth =
            (int)Player.instance.GetComponent<PlayerStats>().health.GetValue();
    }

    public void CurrentStoneText()
    {
        currentPink.text = currentValuePink.ToString();
        currentBlue.text = currentValueBlue.ToString();
        currentRed.text = currentValueRed.ToString();
    }
}