using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeCounter : MonoBehaviour
{
    public float countdownMinutes = 3;
    private float countdownSeconds;
    private Text timeText;
    void Start()
    {
        timeText = GetComponent<Text>();
        countdownSeconds = countdownMinutes;
    }

 
    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"ss");

        if (countdownSeconds <= 0 )
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
