using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiKöpekYeredegme : MonoBehaviour
{
     public bool isGrounded;

    public Animator animator;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("zemin"))
        {
            isGrounded = true;
            
           
        }
    }

    void FixedUpdate()
    {
        if (isGrounded==false)
        {
            animator.SetBool("zıplama", true);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("zemin"))
        {
            isGrounded = false;
           
       
        }
    
    }


}
