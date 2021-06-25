using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grap_Controller : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        RaycastHit2D grabCheck = Physics2D.Raycast(new Vector2(0,0),new Vector2(0,0));
        if (movement > 0)
        {
            grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);
        }
        else if(movement<0)
        {
            grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.left * transform.localScale, rayDist);

        }
        if (grabCheck.collider !=null && grabCheck.collider.tag =="Stuff")
        {
            if (Input.GetKey(KeyCode.G))
            {
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else 
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
}
