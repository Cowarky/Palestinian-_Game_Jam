using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            doExitGame();
        }
    }

    void doExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");

    }
}
