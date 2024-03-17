
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
[CreateAssetMenu(fileName = "Artifact", menuName = "Vault/New Artifact", order = 1)]
public class VaultArtifact : ScriptableObject
{
    public string artifactName;

    public string artifactJobInfo;

    public int maxLevel;

    public float startBoost;
    public float boostPerLevel;

  
    public int[] gemCost;

    [Space(10)]
    public string devLog;
}
