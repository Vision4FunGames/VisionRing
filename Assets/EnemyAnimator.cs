using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    public void DeathEnemy()
    {
        Destroy(transform.parent.gameObject);
    }
}
