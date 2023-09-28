using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerAnimator.Play("Attack1");
        }
    }
}
