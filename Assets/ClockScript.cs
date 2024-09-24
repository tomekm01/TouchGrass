using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    public Text clockText;
    private float time = 60f; // Start the timer at 60 seconds (1 minute)
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        UpdateClockText();
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0) // Ensure the timer doesn't go below 0
        {
            time -= Time.deltaTime; // Decrease time by the time since last frame
            UpdateClockText();
        }
        else
        {
            logic.gameOverScreen();
            clockText.text = "0:00";
        }
    }

    void UpdateClockText()
    {
        int minutes = Mathf.FloorToInt(time / 60); // Get the minutes
        int seconds = Mathf.FloorToInt(time % 60); // Get the seconds
        clockText.text = string.Format("{0:0}:{1:00}", minutes, seconds); // Update the text
    }
}
