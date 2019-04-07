using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    public Rigidbody rb;
    private float forwardSpeed = 250f;
    private float sideSpeed = 200f;

    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardSpeed * Time.deltaTime, 0, 0);
        if(Input.GetKey("left"))
        {
            rb.AddForce(0, 0, sideSpeed * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(0, 0, -sideSpeed * Time.deltaTime);
        }
        if(rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
