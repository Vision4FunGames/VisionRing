using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;
    private bool isFocus = false;
    private Transform player;
    private bool hasInteracted = false;

    private void Awake()
    {
      
    }

    private void OnEnable()
    {
        player = Player.instance.transform;
    }

    public virtual void Interact()
    {
       Debug.Log("Interacting with " + transform.name);
        
    }
    void Update()
    {
        if (isFocus)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
               Interact();
                hasInteracted = true;
            }
        }    
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
    }

    public void OnDeFocused()
    {
        isFocus = false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
