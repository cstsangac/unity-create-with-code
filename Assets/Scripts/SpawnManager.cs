using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public float rangeX = 10f;
    public float repeatSec = 1f;
    private float x;


    void Start()
    {
        x = transform.position.x;
        InvokeRepeating(nameof(Spawn), 0, repeatSec);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x + Random.Range(-rangeX, rangeX), transform.position.y, transform.position.z);
    }

    void Spawn()
    {
        Instantiate(animalPrefabs[Random.Range(0, animalPrefabs.Length)], transform.position, transform.rotation);
    }
}
