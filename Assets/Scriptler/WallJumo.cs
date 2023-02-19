using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJumo : MonoBehaviour
{
    public WallJumo wl ;
    public Animator Animator;
    public bool isGrounded; 
    public float jumpforce = 5;
    
     public Rigidbody2D rb;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("agac"))
        {
            isGrounded = true;
            Animator.SetBool("isJumping",false);
            
        }
    }



    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("agac"))
        {
            isGrounded = false;
            Jump();
        }
    }


    void Jump()
    {
        if(wl.isGrounded == true )
        {
            rb.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }

    }

     void Update() 
     {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Jump();
            isGrounded = false;

        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
             Jump();
             isGrounded = true;
        }
    }

}
