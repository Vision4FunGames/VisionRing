using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_FPSCounter : MonoBehaviour
{
    /* Assign this script to any object in the Scene to display frames per second */

    public float updateInterval = 0.5f; // How often should the number update
    public float averagingInterval = 30.0f; // How many seconds to average FPS over

    float accum = 0.0f;
    int frames = 0;
    float timeleft;
    float fps;

    float averageFpsAccum = 0.0f;
    int averageFrames = 0;
    float averageFps = 0.0f;

    GUIStyle textStyle = new GUIStyle();

    // Use this for initialization
    void Start()
    {
        timeleft = updateInterval;

        textStyle.fontStyle = FontStyle.Bold;
        textStyle.normal.textColor = Color.black;
        textStyle.fontSize = 25;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        // Interval ended - update GUI text and start new interval
        if (timeleft <= 0.0)
        {
            // Display two fractional digits (f2 format)
            fps = (accum / frames);
            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }

        // Calculate average FPS over the last averagingInterval seconds
        averageFpsAccum += Time.timeScale / Time.deltaTime;
        ++averageFrames;

        if (averageFrames >= averagingInterval / updateInterval)
        {
            averageFps = averageFpsAccum / averageFrames;
            averageFpsAccum = 0.0f;
            averageFrames = 0;
        }
    }

    void OnGUI()
    {
        // Display the current FPS and round to 2 decimals
        GUI.Label(new Rect(50, 50, 200, 25), "Current FPS: " + fps.ToString("F2"), textStyle);

        // Display the average FPS over the last averagingInterval seconds
        GUI.Label(new Rect(50, 80, 250, 25), "Average FPS (last " + averagingInterval + " seconds): " + averageFps.ToString("F2"), textStyle);
        GUI.Label(new Rect(50, 110, 250, 25), "Time:" + Time.time.ToString("F2"), textStyle);
    }
}