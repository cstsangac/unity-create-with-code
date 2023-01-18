using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetP5 : MonoBehaviour
{
  public ParticleSystem explosion;

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
      Destory();
      GameManagerP5.AddScore(-1);
    }

  }

  private void OnMouseOver()
  {
    if (Input.GetMouseButton(0))
    {
      Destory();
      GameManagerP5.AddScore(1);
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    Destory();
  }

  private void Destory()
  {
    Destroy(gameObject);
    Instantiate(explosion, transform.position, explosion.transform.rotation);
  }

}
