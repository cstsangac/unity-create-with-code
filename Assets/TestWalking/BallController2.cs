using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController2 : MonoBehaviour
{
    public float moveSpeed = 10f; // Adjust this value to control the ball's speed
    private Rigidbody rb;
    public GameObject ballBg;
    public bool isGrounded;
    public Vector3 velocity;

  // Start is called before the first frame update
  void Start()
    {
        rb = GetComponent<Rigidbody>();
        ballBg = GameObject.Find("BallBg");
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f) * moveSpeed;
        rb.velocity = velocity = movement;
        isGrounded = moveVertical <= 0 && BallController.checkGrounded(transform);

    }
}
