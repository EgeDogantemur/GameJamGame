using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment2 : MonoBehaviour
{
    public float movementSpeed;

    public Rigidbody2D rb;
    
    private Vector2 movementVector;
    
    public ZombiKöpekYeredegme zy ;
    
    public float jumpforce = 15;

    public float downforce = 7 ;

    public float dashforce = 7 ;
    
    Vector3 Scale;
    float horizontal;
    public Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(horizontal * Time.deltaTime * movementSpeed,rb.velocity.y,0f);
       
       
        movementVector = new Vector2(Input.GetAxis("Horizontal"),0f);
       
       
        Animator.SetFloat("Hız",Mathf.Abs(horizontal));
        
        
        transform.Translate(- movementVector * movementSpeed * Time.deltaTime);

        
    
       
        if(Input.GetKeyDown(KeyCode.S))
        {
            Sdown();
        }


        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Dash();
        }
    
       cevirme(horizontal);
    
        if (zy.isGrounded == true && Input.GetKeyDown(KeyCode.W))
    {
        {
            rb.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }

        if (zy.isGrounded == true)
        {
            Animator.SetBool("zıplama", false);
        }
    }
    
    
    }


    

    void Sdown()
    {
        if(zy.isGrounded == false  )
        {
                rb.AddForce(- new Vector2(0f,downforce), ForceMode2D.Impulse);
        }

    }


    void Dash()
    {
        if(zy.isGrounded == false)
        {
                
                rb.AddForce(new Vector2(dashforce,0f), ForceMode2D.Impulse);   
        }
    
       
    
    }


    void cevirme(float horizontal)
    {
        Vector3 karakterscale = transform.localScale;
        if(horizontal > 0 )
        {
            karakterscale.x = -1;
        }
        if(horizontal < 0 )
        {
            karakterscale.x = 1;
        }

        transform.localScale = karakterscale ;



    }









}
