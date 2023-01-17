using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP4 : MonoBehaviour
{
  public float speed = 5.0f;
  public static GameObject self;

  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    self = this.gameObject;
  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.y < -5)
    {
      Destroy(this.gameObject);
    }

    rb.AddForce(Input.GetAxis("Vertical") * speed * RotateCamera.focalPoint.transform.forward);
  }
}
