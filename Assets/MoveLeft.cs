using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10;

    private void Start() {

    }
    // Update is called once per frame
    void Update()
    {
        if (!PlayerControllerP3.gameOver) {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}
