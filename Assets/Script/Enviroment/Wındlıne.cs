using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Wındlıne : MonoBehaviour
{
    private float timer = 1f;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ChangePosition();
            timer = 1f;
        }

    }

    private void ChangePosition()
    {
        float x = UnityEngine.Random.Range(-10f, 10f);
        float y = UnityEngine.Random.Range(5f, 9f);
        float z = UnityEngine.Random.Range(-16f, 10f);
        transform.localPosition = new Vector3(x,y,z);
    }
}
