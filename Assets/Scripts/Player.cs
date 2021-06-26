using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed, sprintSpeed, JumpForce, maximumVelocity;
    Vector3 position;
    static public bool is_Killed;
    public Animator anim;
    bool FacingRight = false;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       float movement = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(movement));
        rb.AddForce( new Vector2(speed * movement, 0));

       // is_Killed = Attack.Player_Killed;
       Debug.Log(rb.position.x);
        
        if (movement < 0 && !FacingRight)
        {
           // FacingRight = false;
            Filp();
        }
        else if (movement >0 && FacingRight)
        {
           // FacingRight = false;
            Filp();
        }

        //CheckJump();
        Jump();

        if (Family_Keeper.family==4)
        {
            FindObjectOfType<LevelLoader>().HappyEnding();

        }
    }
   
    public void OnLanding()
    {
        anim.SetBool("isJumping", false);
    }


    void Filp() 
    {
        FacingRight = !FacingRight;
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;
    }

    void Jump() 
    {
        if (Input.GetKeyDown("up"))
        {
            Debug.Log("Jumping");
            CheckJump();
            rb.AddForce(Vector2.up*speed,ForceMode2D.Impulse);
        }
    }
    void CheckJump()
    {
        if (rb.position.y > 0)
        {
            anim.SetBool("isJumping", true);
            ;
        }
        else
        {
            anim.SetBool("isJumping", false);
        }
    }

}
