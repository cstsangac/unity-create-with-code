using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocityZ = 0.0f;
    public float velocityZAdjustment = 10;
    
    public float rotateFactor = 100;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocityZ += Input.GetAxis("Vertical") / velocityZAdjustment;
        // we will move the vehicle forward
        transform.Translate(velocityZ * Time.deltaTime * Vector3.forward);
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotateFactor * Time.deltaTime);
    }
}
