using System;
using System.Collections.Generic;
using TMPro;
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
    
    private void Awake()
    {
        for (int i = 0; i < vaultArtifacts.Count; i++)
        {
            vaultItems.Add(new VaultItem());
            vaultItems[i].vaultBtn = vaultBtnParent.transform.GetChild(i).GetComponent<Button>();
            vaultItems[i].VaultArtifact = vaultArtifacts[i];
            var i1 = i;
            vaultItems[i].vaultBtn.onClick.AddListener(delegate { ClickVault(i1); });
            vaultItems[i].vaultBtn.transform.GetChild(0).GetComponent<Image>().sprite = vaultArtifacts[i].icon;
        }
    }

    public void ClickVault(int index)
    {
        Debug.Log(index);
        vaultİcon.sprite = vaultArtifacts[index].icon;
        infoVault.text = vaultItems[index].VaultArtifact.artifactJobInfo;
        vaultName.text = vaultItems[index].VaultArtifact.artifactName;
    }
}

[Serializable]
public class VaultItem
{
    public Button vaultBtn;
    public VaultArtifact VaultArtifact;
}