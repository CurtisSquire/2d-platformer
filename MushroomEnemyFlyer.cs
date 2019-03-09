using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MushroomEnemyFlyer : Enemy
{
    private void Update()
    {
        FlyMove();
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "TurnPoint")
        {
            Debug.Log("turn point"); 
            onGround = false; 
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver"); 
        }
        if (col.gameObject.tag == "Ground")
        {
            Debug.Log("onGround"); 
            onGround = true; 
        }
    }
}
