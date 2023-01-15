using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBound : MonoBehaviour
{
    public float limitZ = 100f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limitZ || transform.position.z < -limitZ)
        {
            Destroy(this.gameObject);
        }
    }
}
