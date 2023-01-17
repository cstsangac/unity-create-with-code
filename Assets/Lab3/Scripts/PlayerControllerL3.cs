using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerL3 : MonoBehaviour
{
  public float force = 1000;

  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      rb.AddForce(force * Time.deltaTime * Vector3.forward);
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      rb.AddForce(force * Time.deltaTime * Vector3.back);
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      rb.AddForce(force * Time.deltaTime * Vector3.left);
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
      rb.AddForce(force * Time.deltaTime * Vector3.right);
    }

  }
}
