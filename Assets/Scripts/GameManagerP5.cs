using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerP5 : MonoBehaviour
{

  public float spawnRate = 1;
  public float decreaseSpawnRateAfterSec = 5; // decrease spawn rate every sec
  public float spawnRateMultiplier = 0.8f;


  public List<GameObject> targets;
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(SpawnTarget());
    StartCoroutine(DecreaseSpawnRate());
  }

  IEnumerator SpawnTarget()
  {
    while (true)
    {
      yield return new WaitForSeconds(spawnRate);
      Instantiate(targets[Random.Range(0, targets.Count)]);
    }
  }

  IEnumerator DecreaseSpawnRate()
  {
    yield return new WaitForSeconds(decreaseSpawnRateAfterSec);
    while (true)
    {
      yield return new WaitForSeconds(decreaseSpawnRateAfterSec);
      spawnRate *= spawnRateMultiplier;
      Debug.Log("spawnRate is now " + spawnRate + " s");
    }
  }
}
