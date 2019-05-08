using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotion : MonoBehaviour
{
    public Rigidbody rb;
    public Text currentScore;
    private float score;
    //private float forwardSpeed = 5000f;
    private float sideSpeed = 500f;
    private float ballSpeed = 4f;



    // Update is called once per frame
    void FixedUpdate()
    {
       //  rb.AddTorque(0, 0, -forwardSpeed * Time.deltaTime);
       //  rb.AddForce(ballSpeed * Time.deltaTime, 0, 0);
        rb.AddForceAtPosition(new Vector3(ballSpeed,0,0),new Vector3(rb.position.x, rb.position.y + 0.4f, rb.position.z));
         if(Input.GetKey("left"))
         {
             rb.AddForce(0, 0, sideSpeed * Time.deltaTime);
         }
         if (Input.GetKey("right"))
         {
             rb.AddForce(0, 0, -sideSpeed * Time.deltaTime);
         }
         
        /*float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
        rb.AddTorque(new Vector3(xSpeed, 0, ySpeed) * ballSpeed * Time.deltaTime);*/

        if (rb.position.y < 0.3)
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
