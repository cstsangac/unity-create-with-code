using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerP4 : MonoBehaviour
{

  public GameObject enemyPrefab;
  public float spawnFreq = 3;
  public float spawnRange = 9;
  // Start is called before the first frame update
  void Start()
  {
    Invoke(nameof(Spawn), 1);
  }

  void Spawn()
  {
    float x = Random.Range(-spawnRange, spawnRange);
    float z = Random.Range(-spawnRange, spawnRange);
    Instantiate(enemyPrefab, new Vector3(x, 6, z), enemyPrefab.transform.rotation);
    Invoke(nameof(Spawn), Random.Range(1, spawnFreq));
  }
}
