using System;
using NaughtyAttributes;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RingUpgrade : MonoBehaviour
{
    public int currentValuePink, currentValueRed, currentValueBlue;
    public TextMeshProUGUI currentPink, currentBlue, currentRed;
    public GameObject[] blueStonesUpgrade, redStonesUpgrade;
    public Color[] pinkStonesUprage;
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
        if (!PlayerPrefs.HasKey("HpVal"))
        {
            PlayerPrefs.SetFloat("HpVal",0);
            PlayerPrefs.SetFloat("AtkVal",0);
            PlayerPrefs.SetFloat("DefVal",0);
            PlayerPrefs.SetInt("pinkLevelVal",0);
            PlayerPrefs.SetInt("redLevelVal",0);
            PlayerPrefs.SetInt("blueLevelVal",0);
        }
        HP.value = PlayerPrefs.GetFloat("HpVal");
        ATK.value = PlayerPrefs.GetFloat("AtkVal");
        DEF.value = PlayerPrefs.GetFloat("DefVal");

        pinkLevelVal = PlayerPrefs.GetInt("pinkLevelVal");
        redLevelVal = PlayerPrefs.GetInt("redLevelVal");
        blueLevelVal = PlayerPrefs.GetInt("blueLevelVal");
        
        pinkLevelText.text = (pinkLevelVal + 1).ToString();
        pinkCost.text = pinkSocket.stoneCost[pinkLevelVal].ToString();
        
        redLevelText.text = (redLevelVal + 1).ToString();
        redCost.text = redSocket.stoneCost[redLevelVal].ToString();
        
        blueLevelText.text = (blueLevelVal + 1).ToString();
        blueCost.text = blueSocket.stoneCost[blueLevelVal].ToString();
        
        
        CurrentStoneText();
        pinkBtn.onClick.AddListener(BuyPink);
        redBtn.onClick.AddListener(BuyRed);
        blueBtn.onClick.AddListener(BuyBlue);
        
        hpMulpVal = 1 / ((pinkSocket.HPMultiplier + redSocket.HPMultiplier + blueSocket.HPMultiplier) *
                         (blueSocket.maxLevel - 1));
        atkMulpVal = 1 / ((pinkSocket.ATKMultiplier + redSocket.ATKMultiplier + blueSocket.ATKMultiplier) *
                          (blueSocket.maxLevel - 1));
        defMulpVal = 1 / ((pinkSocket.DEFMultiplier + redSocket.DEFMultiplier + blueSocket.DEFMultiplier) *
                          (blueSocket.maxLevel - 1));
        currentDEFVal = DEFMinValue;
        currentATKVal = ATKMinValue;
        currentHPval = HPMinValue;
        SetCharacterPower();
        RingModelUprage();
    }

    private void OnEnable()
    {
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
            PlayerPrefs.SetInt("pinkLevelVal",pinkLevelVal);
            pinkLevelText.text = (pinkLevelVal + 1).ToString();
            pinkCost.text = pinkSocket.stoneCost[pinkLevelVal].ToString();
            HP.value += hpMulpVal * pinkSocket.HPMultiplier;
            ATK.value += atkMulpVal * pinkSocket.ATKMultiplier;
            DEF.value += defMulpVal * pinkSocket.DEFMultiplier;
            SetCharacterPower();
            RingModelUprage();
          
            
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
            PlayerPrefs.SetInt("redLevelVal",redLevelVal);
            redLevelText.text = (redLevelVal + 1).ToString();
            redCost.text = redSocket.stoneCost[redLevelVal].ToString();
            HP.value += hpMulpVal * redSocket.HPMultiplier;
            ATK.value += atkMulpVal * redSocket.ATKMultiplier;
            DEF.value += defMulpVal * redSocket.DEFMultiplier;
            SetCharacterPower();
            
            RingModelUprage();

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
            PlayerPrefs.SetInt("blueLevelVal",blueLevelVal);
            blueLevelText.text = (blueLevelVal + 1).ToString();
            blueCost.text = blueSocket.stoneCost[blueLevelVal].ToString();
            HP.value += hpMulpVal * blueSocket.HPMultiplier;
            ATK.value += atkMulpVal * blueSocket.ATKMultiplier;
            DEF.value += defMulpVal * blueSocket.DEFMultiplier;
            SetCharacterPower();
            RingModelUprage();
        }
    }

    public void RingModelUprage()
    {
       
        int index = blueLevelVal / 3;
        
        if (index > 0 && index < blueStonesUpgrade.Length)
        {
            blueStonesUpgrade[index].GetComponent<RingScale>().ScaleUp();
        }else if (index >= blueStonesUpgrade.Length)
        {
            blueStonesUpgrade[blueStonesUpgrade.Length - 1].GetComponent<RingScale>().ScaleUp();
            blueStonesUpgrade[1].GetComponent<RingScale>().ScaleUp();
        }
        
       
        index = redLevelVal / 3;
        
        if (index > 0 && index < redStonesUpgrade.Length)
        {
            redStonesUpgrade[index].GetComponent<RingScale>().ScaleUp();
        } else if (index >= redStonesUpgrade.Length)
        {
            redStonesUpgrade[redStonesUpgrade.Length - 1].GetComponent<RingScale>().ScaleUp();
            redStonesUpgrade[1].GetComponent<RingScale>().ScaleUp();
        }

        if (index >= 3)
        {
            redStonesUpgrade[index-3].GetComponent<RingScale>().ScaleDown();
        }
        
     
        index = pinkLevelVal / 3;
            
       
    }
    [Button("sss")]
    public void SetStonesss()
    {
        EconomyManager.instance.SetStoneCount("LightStone", EconomyManager.instance.GetStoneCount("LightStone") + 100);
        EconomyManager.instance.SetStoneCount("LifeStone", EconomyManager.instance.GetStoneCount("LifeStone") + 100);
        EconomyManager.instance.SetStoneCount("DarkStone", EconomyManager.instance.GetStoneCount("DarkStone") + 100);
        CurrentStoneText();
    }

    public void SetCharacterPower()
    {
        currentDEFVal = (int)(Mathf.Ceil(DEFMaxValue * DEF.value));
        currentATKVal = (int)(Mathf.Ceil(ATKMaxValue * ATK.value));
        currentHPval = (int)(Mathf.Ceil(HPMaxValue * HP.value));
        
        PlayerPrefs.SetFloat("HpVal",HP.value);
        PlayerPrefs.SetFloat("AtkVal",ATK.value);
        PlayerPrefs.SetFloat("DefVal",DEF.value);
        
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
        currentValuePink = EconomyManager.instance.GetStoneCount("DarkStone");
        currentValueRed = EconomyManager.instance.GetStoneCount("LifeStone");
        currentValueBlue = EconomyManager.instance.GetStoneCount("LightStone");
        currentPink.text = currentValuePink.ToString();
        currentBlue.text = currentValueBlue.ToString();
        currentRed.text = currentValueRed.ToString();
    }
}