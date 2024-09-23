using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FingerFollower : MonoBehaviour
{
    public Sprite spriteClicked;
    public Sprite spriteUnclicked;
    public Image Image;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) Image.sprite = spriteUnclicked;
        else if (Input.GetMouseButtonUp(0)) Image.sprite = spriteClicked;

        Image.transform.position = Input.mousePosition;
    }

}
