using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
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
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f) * moveSpeed;
        rb.velocity = velocity = movement;
        isGrounded = moveVertical <= 0 && checkGrounded(transform);
    }

    public static bool checkGrounded(Transform transform) {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                return true;
            }
        }
        return false;
    }
}
