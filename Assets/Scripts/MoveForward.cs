using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20;
    public float limitZ = 100f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limitZ || transform.position.z < -limitZ)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
