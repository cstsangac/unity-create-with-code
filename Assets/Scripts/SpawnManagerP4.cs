using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerP4 : MonoBehaviour
{

  public GameObject enemyPrefab;
  public GameObject powerupPrefab;
  public float spawnFreq = 3;
  public float spawnRange = 9;
  // Start is called before the first frame update
  void Start()
  {
    Invoke(nameof(Spawn), 1);
  }

  void Spawn()
  {
    Instantiate(enemyPrefab, new Vector3(Random.Range(-spawnRange, spawnRange), 6, Random.Range(-spawnRange, spawnRange)), enemyPrefab.transform.rotation);
    Instantiate(powerupPrefab, new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange)), enemyPrefab.transform.rotation);
    Invoke(nameof(Spawn), Random.Range(1, spawnFreq));
  }
}
