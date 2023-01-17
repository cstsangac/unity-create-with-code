using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
  public float speed = 50;
  public static GameObject focalPoint;

  private void Start()
  {
    focalPoint = this.gameObject;
  }
  // Update is called once per frame
  void Update()
  {
    transform.Rotate(Input.GetAxis("Horizontal") * speed * Time.deltaTime * Vector3.up);
  }
}
