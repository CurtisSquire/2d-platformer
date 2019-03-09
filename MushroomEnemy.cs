using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;
//creats Mushroom enemy class witch inherits from enemy class. This enemy walks between two points and changes direction 
//when they hit one point. 

public class MushroomEnemy : Enemy
{
    private void Update()
    {
        MoveMent(); 
        
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "TurnPoint")
        {
            Flip(); 
        }
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver"); 
        }
    }
}
