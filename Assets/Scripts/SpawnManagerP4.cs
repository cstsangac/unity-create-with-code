using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerP4 : MonoBehaviour
{

  public GameObject enemyPrefab;
  public GameObject powerupPrefab;
  public float spawnFreq = 3;
  public float spawnRange = 9;


  int numOfNewSpawn = 1;
  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("SpawnManager CurrentThread: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

    StartCoroutine(Spawn());
  }


  IEnumerator Spawn()
  {
    while (true)
    {
      for (int i = 0; i < numOfNewSpawn; i++)
      {
        Instantiate(enemyPrefab, new Vector3(RandPos(), 6, RandPos()), enemyPrefab.transform.rotation);
        Instantiate(powerupPrefab, new Vector3(RandPos(), 0, RandPos()), enemyPrefab.transform.rotation);
      }
      while (true)
      {
        yield return new WaitForSeconds(3);
        if (FindObjectsOfType<EnemyP4>().Length < 1)
        {
          break;
        }
      }
      numOfNewSpawn *= 2;
    }
  }

  float RandPos()
  {
    return Random.Range(-spawnRange, spawnRange);
  }
}
