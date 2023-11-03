using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemAnimator : MonoBehaviour
{
    private Golem1 _golem1;

    private void Awake()
    {
        _golem1 = GetComponentInParent<Golem1>();
    }

    public void MovementAttack()
    {
        _golem1.MovementAttack();
    }
}
