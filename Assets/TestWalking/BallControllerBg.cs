using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerBg : MonoBehaviour
{
    
    private Rigidbody rb;

  // Start is called before the first frame update
  public BallController ballController;
    public BallController2 ballController2;
    public BallController3 ballController3;

    private float oneLegOffGround;
    
    // Start is called before the first frame update
    void Start()
    {
        ballController = GameObject.Find("Ball1").GetComponent<BallController>();
        ballController2 = GameObject.Find("Ball2").GetComponent<BallController2>();
        ballController3 = GameObject.Find("Ball3").GetComponent<BallController3>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 velocity = rb.velocity;

        if (ballController.isGrounded || ballController2.isGrounded) {
            
            float newX = 0;
            if (ballController.isGrounded) newX -= ballController.velocity.x;
            if (ballController2.isGrounded) newX -= ballController2.velocity.x;

            velocity.x = newX;
            velocity.y = ballController3.velocity.y;
        }
        rb.velocity = velocity;
    }
}
