using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
 

    public void SadEnding()
    {
        SceneManager.LoadScene("Ending 2");
    }

    public  void NormalEnding()
    {
        SceneManager.LoadScene("Ending 1");
    }
   public  void HappyEnding()
    {
        SceneManager.LoadScene("Ending 3");
    }


}
