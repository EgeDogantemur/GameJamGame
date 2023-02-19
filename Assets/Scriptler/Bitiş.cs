using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bitiş : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject hitObj = other.gameObject;
        if(hitObj.tag == "player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        GameObject hitObj = other.gameObject;
        if(hitObj.tag == "player2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        }
    }












}
