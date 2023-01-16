using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float canSpawnDogEverySec = 0.5f;
    float canSpawnDogTs = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canSpawnDogTs)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawnDogTs = Time.time + canSpawnDogEverySec;
        }
    }
}
