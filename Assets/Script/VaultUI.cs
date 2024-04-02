using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VaultUI : MonoBehaviour
{
    public List<VaultArtifact> vaultArtifacts;
    public GameObject vaultBtnParent;
    public List<VaultItem> vaultItems;
    public Image vaultİcon;
    public TextMeshProUGUI infoVault;
    public TextMeshProUGUI vaultName;
    public TextMeshProUGUI vaultMultipier, vaultMultiperTo;
    public TextMeshProUGUI buyBtnText;
    public Button buyBtn;
    public int currentIndex;
    public float currentBoost;
    public float levelBoost;

    private void Awake()
    {
        buyBtn.onClick.AddListener(BuyVault);
        for (int i = 0; i < vaultArtifacts.Count; i++)
        {
            vaultItems.Add(new VaultItem());
            vaultItems[i].vaultBtn = vaultBtnParent.transform.GetChild(i).GetComponent<Button>();
            vaultItems[i].VaultArtifact = vaultArtifacts[i];
            var i1 = i;
            vaultItems[i].vaultBtn.onClick.AddListener(delegate { ClickVault(i1); });
            vaultItems[i].vaultBtn.transform.GetChild(0).GetComponent<Image>().sprite = vaultArtifacts[i].icon;

            if (!PlayerPrefs.HasKey(vaultItems[i].VaultArtifact.artifactName))
            {
                PlayerPrefs.SetInt(vaultItems[i].VaultArtifact.artifactName, 1);
            }

            vaultItems[i].vaultBtn.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text =
                "Level" + PlayerPrefs.GetInt(vaultItems[i].VaultArtifact.artifactName);
        }
        
        ClickVault(0);
       
    }

    private void Start()
    {
        StartPlayerStat();
    }

    public void StartPlayerStat()
    {
        for (int i = 0; i < vaultArtifacts.Count; i++)
        {
            levelBoost = PlayerPrefs.GetInt(vaultItems[i].VaultArtifact.artifactName) *
                         vaultItems[i].VaultArtifact.boostPerLevel;
            currentBoost = (vaultItems[i].VaultArtifact.startBoost) +
                           ((vaultItems[i].VaultArtifact.startBoost) * levelBoost);
            SetCharacters(vaultItems[i].VaultArtifact.artifactName,currentBoost);
        }
    }

    public void ClickVault(int index)
    {
        currentIndex = index;
        int vaultLevel = PlayerPrefs.GetInt(vaultItems[currentIndex].VaultArtifact.artifactName);
        if (vaultLevel < 49)
        {
            levelBoost = PlayerPrefs.GetInt(vaultItems[currentIndex].VaultArtifact.artifactName) *
                         vaultItems[currentIndex].VaultArtifact.boostPerLevel;
            currentBoost = (vaultItems[currentIndex].VaultArtifact.startBoost) +
                           ((vaultItems[currentIndex].VaultArtifact.startBoost) * levelBoost);

            vaultİcon.sprite = vaultArtifacts[index].icon;
            infoVault.text = vaultItems[index].VaultArtifact.artifactJobInfo;
            vaultName.text = vaultItems[index].VaultArtifact.artifactName;


            vaultMultipier.text = "x" + currentBoost;
            vaultMultiperTo.text = "x" + (currentBoost + vaultItems[currentIndex].VaultArtifact.boostPerLevel);
            buyBtnText.text =
                "" + vaultItems[index].VaultArtifact
                    .gemCost[PlayerPrefs.GetInt(vaultItems[index].VaultArtifact.artifactName)] *
                vaultItems[index].VaultArtifact.gemCostMultiplier;
            vaultItems[index].vaultBtn.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text =
                "Level" + PlayerPrefs.GetInt(vaultItems[index].VaultArtifact.artifactName);
        }
    }

    public void BuyVault()
    {
        
        float currentd = Player.instance.GetComponent<PlayerStats>().damage.GetValue();
       

        int vaultLevel = PlayerPrefs.GetInt(vaultItems[currentIndex].VaultArtifact.artifactName);
        if (vaultLevel < 49)
        {
            PlayerPrefs.SetInt(vaultItems[currentIndex].VaultArtifact.artifactName, vaultLevel + 1);
            levelBoost = PlayerPrefs.GetInt(vaultItems[currentIndex].VaultArtifact.artifactName) *
                         vaultItems[currentIndex].VaultArtifact.boostPerLevel;
            currentBoost = vaultItems[currentIndex].VaultArtifact.startBoost + levelBoost;

            vaultMultipier.text = "x" + currentBoost;
            vaultMultiperTo.text = "x" + (currentBoost + vaultItems[currentIndex].VaultArtifact.boostPerLevel);
            buyBtnText.text = "" + vaultItems[currentIndex].VaultArtifact
                    .gemCost[PlayerPrefs.GetInt(vaultItems[currentIndex].VaultArtifact.artifactName)] *
                vaultItems[currentIndex].VaultArtifact.gemCostMultiplier;
            vaultItems[currentIndex].vaultBtn.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text =
                "Level" + PlayerPrefs.GetInt(vaultItems[currentIndex].VaultArtifact.artifactName);
            SetCharacters(vaultItems[currentIndex].VaultArtifact.artifactName, currentBoost);
        }
    }

    public void SetCharacters(string vaultName, float currentBoost)
    {
        switch (vaultName)
        {
            case "Antique Sword":
                if (currentBoost > 1)
                {
                    Player.instance.GetComponent<PlayerStats>().damage.ZeroIndexRemove();
                }

                float currentDamage = Player.instance.GetComponent<PlayerStats>().damage.GetValue() * currentBoost;
                currentDamage -= Player.instance.GetComponent<PlayerStats>().damage.GetValue();

                Player.instance.GetComponent<PlayerStats>().damage.AddModifier(currentDamage);
                break;
            case "Antique Armor":
                break;
            case "Antique Boots":
                break;
            case "Antique Helmet":
                if (currentBoost > 1)
                {
                    Player.instance.GetComponent<PlayerStats>().health.ZeroIndexRemove();
                }
                float health = Player.instance.GetComponent<PlayerStats>().health.GetValue() * currentBoost;
                health -= Player.instance.GetComponent<PlayerStats>().health.GetValue();
                Player.instance.GetComponent<PlayerStats>().health.AddModifier(health);
                Player.instance.GetComponent<PlayerStats>().maxHealth =
                    (int)Player.instance.GetComponent<PlayerStats>().health.GetValue();
                break;
            case "Wizards Legacy":
                break;
            case "Midas Ring":
                break;
            case "The Blessing of Priapos":
                break;
        }
    }
}
[Serializable]
public class VaultItem
{
    public Button vaultBtn;
    public VaultArtifact VaultArtifact;
}