using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboAttack : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<PlayerAttack>().isComboAttackBool = true;
    }
}
