using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float maxDistance = 100f;

    void Update()
    {
        // Get the local direction of +y axis in world space
        Vector3 rayDirection = transform.TransformDirection(Vector3.up);

        // Raycast to detect hits
        RaycastHit hit;
        if (Physics.Raycast(transform.position, rayDirection, out hit, maxDistance))
        {
            // Draw the ray as debug drawing
            Debug.DrawRay(transform.position, rayDirection * hit.distance, Color.green);

            // Set the scale on y axis based on the distance
            float newScaleY = Mathf.Clamp(hit.distance, 0f, maxDistance);
            transform.localScale = new Vector3(transform.localScale.x, newScaleY/2, transform.localScale.z);
        }
        else
        {
            // Draw the ray as debug drawing up to the maximum distance
            Debug.DrawRay(transform.position, rayDirection * maxDistance, Color.red);

            // Set the scale on y axis to the maximum distance
            transform.localScale = new Vector3(transform.localScale.x, maxDistance, transform.localScale.z);
        }
    }
}
