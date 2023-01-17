using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyP4 : MonoBehaviour
{
  public float speed = 3;
  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.y < -5)
    {
      Destroy(this.gameObject);
    }

    Vector3 towardsPlayer = (PlayerControllerP4.self.transform.position - transform.position).normalized;
    rb.AddForce(towardsPlayer * speed);
  }
}
