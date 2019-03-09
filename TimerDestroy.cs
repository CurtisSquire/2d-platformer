using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
//this class was created to make sure that bullets the player shoots will destroy themselves after some time has passed.
    [SerializeField] float timer;

    private void Start()
    {
        Destroy(gameObject, timer);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Enemy" && col.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
