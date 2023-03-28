using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController3 : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Vector3 velocity;
    private Rigidbody rb;

  // Start is called before the first frame update
  public GameObject ball1;
    public GameObject ball2;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical3");

        Vector3 movement = new Vector3(0.0f, moveVertical, 0.0f) * moveSpeed;
        rb.velocity = velocity = movement;
        
    }
}
