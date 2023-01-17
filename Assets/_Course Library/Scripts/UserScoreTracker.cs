using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserScoreTracker : MonoBehaviour
{
    public int score = 0;
    public int totalSeconds = 0;
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(time());
    }
    
    
    // Update is called once per frame
    void Update()
    {
        //Store TimeSpan into variable.
        var timeSpanConversionHours = TimeSpan.FromSeconds(totalSeconds).Hours;
        var timeSpanConversionMinutes = TimeSpan.FromSeconds(totalSeconds).Minutes;
        var timeSpanConversionSeconds = TimeSpan.FromSeconds(totalSeconds).Seconds;

        timeText.text = ("Elapsed Time: " 
            + timeSpanConversionHours.ToString("00") + ":"
            + timeSpanConversionMinutes.ToString("00") + ":" 
            + timeSpanConversionSeconds.ToString("00"));
    }

    void timeCount()
    {
        totalSeconds += 1;
    }

    IEnumerator time()
    {
        while (true)
        {
            timeCount();
            yield return new WaitForSeconds(1);
        }
    }
}
