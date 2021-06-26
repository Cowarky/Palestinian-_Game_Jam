using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack_Timer : MonoBehaviour
{
    private float timeValue=60;
    public Text TimerText;
    private int Attack_Counter=1;
    // Update is called once per frame
    void Update()
    {
        //checkAttack();


        if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
            Attack_Counter++;
            checkAttack();
             }

            DisplayTime(timeValue);
    }
    void checkAttack() 
    {
        if (Attack_Counter == 1)
        {
            timeValue = 60;
        }
        else if (Attack_Counter == 2)
        {
            timeValue = 60;
        }
        else if (Attack_Counter == 3)
        {
            timeValue = 60;
        }
        else if (Attack_Counter == 4)
        {
            timeValue = 60;
        }

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
