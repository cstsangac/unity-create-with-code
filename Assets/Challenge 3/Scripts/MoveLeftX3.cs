using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX3 : MonoBehaviour
{
  public float speed;

  private float leftBound = -10;

  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    if (PlayerControllerX3.gameOver)
    {
      return;
    }
    // If game is not over, move to the left
    transform.Translate(speed * Time.deltaTime * Vector3.left, Space.World);

    // If object goes off screen that is NOT the background, destroy it
    if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
    {
      Destroy(gameObject);
    }

  }
}
