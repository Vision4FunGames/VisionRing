using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleChest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            GetComponent<Animator>().SetTrigger("Open");
    }
}
