using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillRow : MonoBehaviour
{
    // Start is called before the first frame update
    public int index;
    public InventorySlot slot;
    public TextMeshProUGUI skillDescriptionText;
    void Start()
    {
        skillDescriptionText = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
