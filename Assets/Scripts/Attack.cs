using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public SpriteRenderer sprite;
    private Color Attacked = new Color(229, 0, 0, 50);
    private Color Destroyed = new Color32(41, 34, 34, 230);
    static public bool Player_Killed, Family_Killed, player_Stay;
    int members = 0, Player_layer=7;

    private void Start()
    {
        if (gameObject.layer == 8)
        { gameObject.GetComponent<BoxCollider2D>().isTrigger = false; }
        else
        {
            if (gameObject.name == "Window 1")
            {
                StartCoroutine(FlashRed(60f));
                StartCoroutine(Destroy_Window(9, 45f));

            }
            else if (gameObject.name == "Window 2")
            {
                StartCoroutine(FlashRed(240f));
                StartCoroutine(Destroy_Window(10, 100f));

            }
            else if (gameObject.name == "Window 3")
            {
                StartCoroutine(FlashRed(120f));
                StartCoroutine(Destroy_Window(11, 55f));


            }
            else if (gameObject.name == "Window 4")
            {
                StartCoroutine(FlashRed(180f));
                StartCoroutine(Destroy_Window(12, 75f));

            }
        }
    }
 



    public IEnumerator FlashRed(float n) 
    {
        yield return new WaitForSeconds(n);
        sprite.color = new Color32(229, 0, 0, 50);
        yield return new WaitForSeconds(0.1f);
        sprite.color = Destroyed;
        gameObject.layer = 8;
       // Debug.Log(gameObject.name + "is"+gameObject.layer);
    }

    public IEnumerator Destroy_Window(int room, float n)
    {
        yield return new WaitForSeconds(n);
        GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach (GameObject go in gos)
        {
            if (go.layer == room)
            {

                if (go.CompareTag("Stuff"))
                {
                    Destroy(go);
                }

                else if (go.CompareTag("Family"))
                {
                    Family_Killed = true;
                    // Debug.Log("Family is killed");
                    if (Family_Keeper.family != 4 && Player_layer != go.layer)
                    {
                        yield return new WaitForSeconds(0.8f);
                        FindObjectOfType<LevelLoader>().SadEnding();
                    }
                }
                else if (Family_Keeper.family == 4 && Player_layer == go.layer)
                {
                    yield return new WaitForSeconds(0.8f);
                    FindObjectOfType<LevelLoader>().HappyEnding();

                }
                else {
                    yield return new WaitForSeconds(0.8f);
                    FindObjectOfType<LevelLoader>().NormalEnding();

                }
            }
        }
      
        // Debug.Log(gameObject.name + "is"+gameObject.layer);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            player_Stay = false;
            Player_layer = 7;
          //  Debug.Log("Stay "+player_Stay);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            player_Stay = true;
            Player_layer = gameObject.layer;
            Debug.Log("Stay " + player_Stay +"at"+gameObject.layer);
        }
    }

}