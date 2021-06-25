using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 240;
    public Text TimerText;

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
          //  FindObjectOfType<LevelLoader>().HappyEnding();

        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDesplay)
    {
        if (timeToDesplay < 0)
        {
            timeToDesplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDesplay / 60);
        float seconds = Mathf.FloorToInt(timeToDesplay % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}