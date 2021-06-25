using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Scene : MonoBehaviour
{
    // Start is called before the first frame update

    void PlayGame(string SceneName) 
    {
        SceneManager.LoadScene(SceneName);
        
    }
}
