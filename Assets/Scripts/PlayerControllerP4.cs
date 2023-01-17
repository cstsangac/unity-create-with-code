using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP4 : MonoBehaviour
{
  public float speed = 5.0f;

  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    rb.AddForce(Input.GetAxis("Vertical") * speed * RotateCamera.focalPoint.transform.forward);
  }
}
