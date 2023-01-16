using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX1 : MonoBehaviour
{
    public float speed = 10;
    public float rotationSpeed = 100;



    // Update is called once per frame
    void FixedUpdate()
    {


        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime * Vector3.right);
    }
}
