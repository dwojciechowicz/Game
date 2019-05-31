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
    private float sideSpeed = 600f;
    private float ballSpeed = 7f;



    // Update is called once per frame
    void FixedUpdate()
    {
       //  rb.AddTorque(0, 0, -forwardSpeed * Time.deltaTime);
         //rb.AddForce(ballSpeed * Time.deltaTime, 0, 0);
        rb.AddForceAtPosition(new Vector3(ballSpeed,0,0),new Vector3(rb.position.x, rb.position.y + 0.45f, rb.position.z));
        
        if (Input.touchCount > 0)
       {
       //     if(Input.GetKey("left"))
          if (Input.GetTouch(0).position.x <= (Screen.width/2))
            {
                rb.AddForce(0, 0, sideSpeed * Time.deltaTime);
            }
         //   if (Input.GetKey("right"))
            else
            {
                rb.AddForce(0, 0, -sideSpeed * Time.deltaTime);
            }
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
    void OnTriggerStay(Collider other)
    {
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }
    void OnTriggerExit(Collider other)
    {
        rb.constraints = RigidbodyConstraints.None;
    }
    public float getScore()
    {
        return score;
    }
}
