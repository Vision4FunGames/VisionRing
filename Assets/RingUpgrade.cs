using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class RingUpgrade : MonoBehaviour
{
    public int currentValuePink, currentValueRed, currentValueBlue;
    public TextMeshProUGUI currentPink, currentBlue, currentRed;
    public Slider HP, ATK, DEF;
    
    
    [Header("_________________________________")]
    public RingSocket blueSocket;
    public RingSocket redSocket;
    public RingSocket pinkSocket;

    [Header("_________________________________")]
    public int HPMinValue;
    public int HPMaxValue;

    [Header("_________________________________")]
    public int ATKMinValue;
    public int ATKMaxValue;

    [Header("_________________________________")]
    public int DEFMinValue;
    public int DEFMaxValue;

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

        hpMulpVal = 1 / ((pinkSocket.HPMultiplier + redSocket.HPMultiplier + blueSocket.HPMultiplier)*50);
        atkMulpVal = 1 / ((pinkSocket.ATKMultiplier + redSocket.ATKMultiplier + blueSocket.ATKMultiplier)*50);
        defMulpVal = 1 / ((pinkSocket.DEFMultiplier + redSocket.DEFMultiplier + blueSocket.DEFMultiplier)*50);
    }

    public void BuyPink()
    {
        if (pinkSocket.stoneCost[pinkLevelVal] < currentValuePink && pinkLevelVal+1<pinkSocket.stoneCost.Length)
        {
            currentValuePink -= pinkSocket.stoneCost[pinkLevelVal];
            CurrentStoneText();
            pinkLevelVal++;
            pinkLevelText.text = pinkLevelVal.ToString();
            pinkCost.text = pinkSocket.stoneCost[pinkLevelVal].ToString();
            HP.value += hpMulpVal*pinkSocket.HPMultiplier;
            ATK.value += atkMulpVal*pinkSocket.ATKMultiplier;
            DEF.value += defMulpVal*pinkSocket.DEFMultiplier;
        }
    }

    public void BuyRed()
    {
        if (redSocket.stoneCost[redLevelVal] < currentValueRed-1&& redLevelVal+1<redSocket.stoneCost.Length)
        {
            currentValueRed -= pinkSocket.stoneCost[redLevelVal];
            CurrentStoneText();
            redLevelVal++;
            redLevelText.text = redLevelVal.ToString();
            redCost.text = redSocket.stoneCost[redLevelVal].ToString();
            HP.value += hpMulpVal*redSocket.HPMultiplier;
            ATK.value += atkMulpVal*redSocket.ATKMultiplier;
            DEF.value += defMulpVal*redSocket.DEFMultiplier;
        }
    }

    public void BuyBlue()
    {
        if (blueSocket.stoneCost[blueLevelVal] < currentValueBlue-1&& blueLevelVal+1<blueSocket.stoneCost.Length)
        {
            currentValueBlue -= pinkSocket.stoneCost[blueLevelVal];
            CurrentStoneText();
            blueLevelVal++;
            blueLevelText.text = blueLevelVal.ToString();
            blueCost.text = blueSocket.stoneCost[blueLevelVal].ToString();
            HP.value += hpMulpVal*blueSocket.HPMultiplier;
            ATK.value += atkMulpVal*blueSocket.ATKMultiplier;
            DEF.value += defMulpVal*blueSocket.DEFMultiplier;
        }
    }


    public void CurrentStoneText()
    {
        currentPink.text = currentValuePink.ToString();
        currentBlue.text = currentValueBlue.ToString();
        currentRed.text = currentValueRed.ToString();
    }
}
