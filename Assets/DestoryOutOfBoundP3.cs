using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBoundP3 : MonoBehaviour
{
    public float limit = -20;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < limit || transform.position.y < limit || transform.position.z < limit) {
            Destroy(gameObject);
        }
        
    }
}
