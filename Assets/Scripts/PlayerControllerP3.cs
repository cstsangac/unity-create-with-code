using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP3 : MonoBehaviour
{
    public float jumpForce = 10;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    public static bool gameOver = false;

    Rigidbody rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    void Update() {
        if (gameOver) {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            animator.SetTrigger("Jump_trig");
        }
    }    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground")) {
            isOnGround = true;
        } else if (other.gameObject.CompareTag("Obstacle")) {
            gameOver = true;
            Debug.Log("Game Over!");
            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int", 1);
        }
    }
    
}
