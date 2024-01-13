using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private Player player;
    public GameObject targetpuzzle;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
        targetpuzzle = FindObjectOfType<PuzzleController>().gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            player.transform.position = targetpuzzle.transform.position;

    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}