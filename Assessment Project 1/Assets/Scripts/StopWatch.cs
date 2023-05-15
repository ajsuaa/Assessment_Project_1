//THIS SCRIPT IS FROM A TUTORIAL

using System;
using UnityEngine;
using TMPro;

public class StopWatch : MonoBehaviour
{
    //The current timme of the stopwatch
    float currentTime;
    // Orginially, the variable was called "Text" instead of "TMP_Text". It was replaced due to my computer using Text Mesh Pro
    public TMP_Text currentTimeText;

    void Start()
    {
        // In the beggining, the timer starts at 0
        currentTime = 0;
    }

    void FixedUpdate()
    {
        //The current is overlapped by the fixed delta time 
        currentTime += Time.fixedDeltaTime;

        // Makes the current time to a TimeSpan object
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        // Update the text object with the current time 
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }
}