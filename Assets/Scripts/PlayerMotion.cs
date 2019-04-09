using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotion : MonoBehaviour
{
    public Rigidbody rb;
    public Text currentScore;
    private float score;
    private float forwardSpeed = 250f;
    private float sideSpeed = 250f;
    

    
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
        if(rb.position.y < 0.3)
        {
            enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }

        score = rb.position.x/10.0f;
        currentScore.text = ((int)score).ToString();
    }
    public float getScore()
    {
        return score;
    }
}
