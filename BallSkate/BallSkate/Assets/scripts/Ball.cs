using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector2 first = Vector2.zero;
    private Vector2 second = Vector2.zero;
    public float leftForce = -200;                   //Upward force of the "flap".
    public float rightForce = 200;  
    private bool isDead = false;            //Has the player collided with a wall?

    private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("update");
        if (isDead == false)
        {
            //Look for input to trigger a "flap".
            if (Input.GetMouseButtonDown(0))
            {
                first = new Vector2(Screen.width/2,Screen.height/2);
                second = Input.mousePosition;
                rb2d.velocity = Vector2.zero;
                if (second.x > first.x)
                {
                    //..giving the bird some upward force.
                    rb2d.AddForce(new Vector2(rightForce, 0));
                }
                else
                {
                    rb2d.AddForce(new Vector2(leftForce, 0));
                }
                Debug.Log("    " + Input.mousePosition);
                Debug.Log("Input.GetMouseButtonDown");
                //...zero out the birds current y velocity before...
            }
        }
    }

    void OnTriggerEnter(Collider collider)  
    {
        Debug.Log("OnTriggerEnter");
    }

    void OnCollisionEnter(Collision collision)   
    {  
        //进入碰撞器执行的代码
        Debug.Log("OnCollisionEnter");
    }
}
