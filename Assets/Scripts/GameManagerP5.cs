using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerP5 : MonoBehaviour
{

  public float spawnRate = 1;
  public float decreaseSpawnRateAfterSec = 5; // decrease spawn rate every sec
  public float spawnRateMultiplier = 0.8f;
  public static TextMeshProUGUI scoreText;
  public static GameObject gameOverText;
  public static GameObject gameOverButton;
  public static int score;

  public static bool gameOver;

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
    while (!gameOver)
    {
      yield return new WaitForSeconds(spawnRate);
      Instantiate(targets[Random.Range(0, targets.Count)]);
    }
  }

  IEnumerator DecreaseSpawnRate()
  {
    yield return new WaitForSeconds(decreaseSpawnRateAfterSec);
    while (!gameOver)
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

    if (score < 0)
    {
      if (gameOverText == null)
      {
        gameOverText = GameOverTextP5.obj;
      }
      gameOver = true;
      DisplayGameOver(gameOver);
    }
  }

  public static void RestartGame()
  {
    score = 0;
    gameOver = false;
    DisplayGameOver(gameOver);
    Debug.Log("Restart Game! " + SceneManager.GetActiveScene().name);
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public static void DisplayGameOver(bool active)
  {
    if (gameOverText == null)
    {
      gameOverText = GameOverTextP5.obj;
    }
    if (gameOverButton == null)
    {
      gameOverButton = RestartButtonP5.obj;
    }

    gameOverText.SetActive(active);
    gameOverButton.SetActive(active);
  }
}
