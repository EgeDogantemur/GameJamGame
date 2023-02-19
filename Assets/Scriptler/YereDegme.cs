using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YereDegme : MonoBehaviour
{
    public bool isGrounded;

    public Animator Animator;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("zemin"))
        {
            isGrounded = true;
            Animator.SetBool("isJumping",false);
            
        }
    }



    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("zemin"))
        {
            isGrounded = false;
            Animator.SetBool("isJumping",true);
        }
    }













}
