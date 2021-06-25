using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeKeeper : MonoBehaviour
{
    [SerializeField] GameObject PlayerPrefab;
    [SerializeField] GameObject roomPrefab_1;
    [SerializeField] GameObject roomPrefab_2;
    [SerializeField] GameObject roomPrefab_3;
    [SerializeField] GameObject roomPrefab_4;

    public Text TextLife;
    int lives = 3;

    // Start is called before the first frame update
   
    public void DecreaseLives(int room)
    {
        lives--;
        TextLife.text = lives.ToString();
        if (lives > 0 && Family_Keeper.family != 4)
        {
            GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject go in gos)
            {
                if (go.layer == room)
                {
                  Destroy(go);  
                }
            }
            RespawnPlayer();
            RespawnRoom(room);
        }
        else if (lives > 0 && Family_Keeper.family == 4)
        {
            FindObjectOfType<LevelLoader>().HappyEnding();
        }
        else if (Family_Keeper.family != 4)
        {
            FindObjectOfType<LevelLoader>().NormalEnding();
        }
        
    }

    private void RespawnPlayer()
    {
        Vector3 respawnPosition = new Vector3(-8, -2.5f, 0);
        Instantiate(PlayerPrefab, respawnPosition, Quaternion.identity);
    }

    private void RespawnRoom(int RoomNum)
    {

        Vector3 respawnPosition;
        if (RoomNum==9)
        {
             respawnPosition = new Vector3(0, 0, 0);
            Instantiate(roomPrefab_1, respawnPosition, Quaternion.identity);

        }
        else if (RoomNum == 10)
        {
            respawnPosition = new Vector3(0, 0, 0);
            Instantiate(roomPrefab_2, respawnPosition, Quaternion.identity);

        }
        else if (RoomNum == 11)
        {
            respawnPosition = new Vector3(0, 0, 0);
            Instantiate(roomPrefab_3, respawnPosition, Quaternion.identity);

        }
        else if (RoomNum == 12)
        {
            respawnPosition = new Vector3(2.89f, -2.27f, 0);
            Instantiate(roomPrefab_4, respawnPosition, Quaternion.identity);

        }
    }
}
