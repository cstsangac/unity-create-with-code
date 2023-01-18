using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetP5 : MonoBehaviour
{

  private float minSpeed = 12;
  private float maxSpeed = 16;
  private float maxTorque = 10;
  private float xRange = 4;
  private float ySpawnPos = 0;

  Rigidbody rb;
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    rb.AddForce(Vector3.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
    rb.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
    transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
  }

  private void Update()
  {
    if (transform.position.y < ySpawnPos)
    {
      Destroy(gameObject);
    }
  }

  private void OnMouseDown()
  {
    Destroy(gameObject);
  }

  private void OnTriggerEnter(Collider other)
  {
    Destroy(gameObject);
  }

}
