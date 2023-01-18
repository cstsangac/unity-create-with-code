using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerP5 : MonoBehaviour
{

  public float spawnRate = 1;
  public float decreaseSpawnRateAfterSec = 5; // decrease spawn rate every sec
  public float spawnRateMultiplier = 0.8f;
  public static TextMeshProUGUI scoreText;
  public static int score;


  public List<GameObject> targets;
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(SpawnTarget());
    StartCoroutine(DecreaseSpawnRate());
    AddScore(0);
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

  public static void AddScore(int scoreToAdd)
  {
    if (scoreText == null)
    {
      scoreText = ScoreTextP5.self;
    }
    score += scoreToAdd;
    scoreText.text = "Score: " + score;
  }
}
