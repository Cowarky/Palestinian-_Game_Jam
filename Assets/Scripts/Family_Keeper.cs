using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Family_Keeper : MonoBehaviour
{
     public static int family = 0;
    public Text textFamily;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {
            Debug.Log("Take a a family member");
            family++;
            textFamily.text = "Saved: 4/" + family.ToString();
            Destroy(gameObject);
        }

    }
}
