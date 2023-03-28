using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ball3;
    

    // Start is called before the first frame update
    void Start()
    {
        ball3 = GameObject.Find("Ball3");
        Vector3 v = ball3.transform.position;
        transform.position = new Vector3(v.x, v.y, v.z - 10f);

    }

    void LateUpdate()
    {
        Vector3 v = ball3.transform.position;
        transform.position = new Vector3(v.x, transform.position.y, transform.position.z);
    }

}
