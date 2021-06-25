using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
 

    public void SadEnding()
    {
        SceneManager.LoadScene(4);
    }

    public  void NormalEnding()
    {
        SceneManager.LoadScene(3);
    }
   public  void HappyEnding()
    {
        SceneManager.LoadScene(5);
    }


}
