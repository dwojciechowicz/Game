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

   // private float sideSpeed = 750f;
   // private float ballSpeed = 7f;



    // Update is called once per frame
    void FixedUpdate()
    {
        //  rb.AddTorque(0, 0, -forwardSpeed * Time.deltaTime);
        //rb.AddForce(ballSpeed * Time.deltaTime, 0, 0);
        ForwardMotion fm;
        fm = new ForwardMotion();
        fm.Move(rb);
        
        if (Input.touchCount > 0)
       {
            SideMotion sm;
            sm = new SideMotion();
            //     if(Input.GetKey("left"))
            if (Input.GetTouch(0).position.x <= (Screen.width/2))
            {
                int x = 1;
                sm.Move(rb, x);
            }
         //   if (Input.GetKey("right"))
            else
            {
                int x = -1;
                sm.Move(rb, x);
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
public class ForwardMotion
{
    private float ballSpeed = 7f;
    public void Move(Rigidbody rb)
    {
        rb.AddForceAtPosition(new Vector3(ballSpeed, 0, 0), new Vector3(rb.position.x, rb.position.y + 0.45f, rb.position.z));
    }
}
public class SideMotion
{
    private float sideSpeed = 750f;
    public void Move(Rigidbody rb, int x)
    {
        rb.AddForce(0, 0, x * sideSpeed * Time.deltaTime);
    }
}
