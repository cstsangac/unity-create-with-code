using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerControler : MonoBehaviour
{
    public float speed = 20f;
    public float limitX = 10f;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime * Vector3.right);
        if (transform.position.x > limitX)
        {
            transform.position = new(limitX, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -limitX)
        {
            transform.position = new(-limitX, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

    }


}
