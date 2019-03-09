using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
//Here is where I set up the player controler. 
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float gravityMult;
    float horizontal; 
    private float jumpValue = 300;
    private bool onGround;
    [SerializeField] Transform shotSpawn;
    public  Rigidbody2D bulletRB;
    [SerializeField] float shootingTimer;
    [SerializeField] float rateOfFire;
    [SerializeField] float shotForce;
    protected Rigidbody2D instanceBullet; 
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
    //this controls the players movement. 
    private void Movement(float horizontal)
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);  
    }
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); 
        Movement(horizontal); 
        //controls the player jumping. 
        if (Input.GetKeyDown(KeyCode.W) && onGround)
        {
            onGround = false;
            rb.AddForce(new Vector2(rb.velocity.x, jumpValue));
        }
         //allows the player to shoot every few seaconds when space is pressed. 
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > shootingTimer)
        {
            shootingTimer = Time.time + rateOfFire;
            instanceBullet = Instantiate(bulletRB, shotSpawn.position, shotSpawn.rotation) as Rigidbody2D;
            instanceBullet.AddForce(shotSpawn.right * shotForce, ForceMode2D.Impulse);
        }
    }
}
