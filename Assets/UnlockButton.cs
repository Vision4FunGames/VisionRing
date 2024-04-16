using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockButton : MonoBehaviour
{
    public int unlockLevel;
    public Sprite colorSprite;
    void Start()
    {
        CheckPlayerLevelForUnlock();
    }

    public void CheckPlayerLevelForUnlock()
    {
        if (Player.instance.GetComponent<PlayerLevel>().currentLevel >= unlockLevel)
        {
            GetComponent<Button>().interactable = true;
        }

        if (colorSprite != null)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = colorSprite;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
