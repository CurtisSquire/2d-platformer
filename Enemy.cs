using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isFacingRight;
    public bool onGround;
    public float speed = 1; 
    public Vector2 leftVel;
    public Vector2 rightVel;
    public Vector2 upVel;
    public Vector2 downVel; 

    public void MoveMent()
    {
        if (isFacingRight)
        {
            rb.MovePosition(rb.position + leftVel * Time.fixedDeltaTime); 
        }
        if (!isFacingRight)
        {
            rb.MovePosition(rb.position + rightVel * Time.fixedDeltaTime); 
        }

    }
    public void FlyMove()
    {
        if (onGround)
        {
            rb.velocity = upVel; 
        }
        else if (!onGround)
        {
            rb.velocity = downVel; 
        }
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180.0f, 0f); 
    }

    
}
