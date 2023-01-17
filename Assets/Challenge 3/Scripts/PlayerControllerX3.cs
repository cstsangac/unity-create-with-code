﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX3 : MonoBehaviour
{
  public static bool gameOver;

  public float floatForce;
  private float gravityModifier = 1.5f;
  private Rigidbody playerRb;

  public ParticleSystem explosionParticle;
  public ParticleSystem fireworksParticle;

  private AudioSource playerAudio;
  public AudioClip moneySound;
  public AudioClip explodeSound;


  // Start is called before the first frame update
  void Start()
  {
    Physics.gravity *= gravityModifier;
    playerAudio = GetComponent<AudioSource>();

    playerRb = GetComponent<Rigidbody>();
    // Apply a small upward force at the start of the game
    playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

  }

  // Update is called once per frame
  void Update()
  {
    if (gameOver)
    {
      return;
    }
    // While space is pressed and player is low enough, float up
    if (Input.GetKey(KeyCode.Space))
    {
      playerRb.AddForce(Vector3.up * floatForce);
    }

    if (transform.position.y > RepeatBackgroundX3.backgroundHeight)
    {
      transform.position = new Vector3(transform.position.x, (float)RepeatBackgroundX3.backgroundHeight, transform.position.z);
      playerRb.velocity = Vector3.zero;
    }
  }

  private void OnCollisionEnter(Collision other)
  {
    if (gameOver)
    {
      return;
    }
    // if player collides with bomb, explode and set gameOver to true
    if (other.gameObject.CompareTag("Bomb"))
    {
      explosionParticle.Play();
      playerAudio.PlayOneShot(explodeSound, 1.0f);
      gameOver = true;
      Debug.Log("Game Over!");
      Destroy(other.gameObject);
    }

    // if player collides with money, fireworks
    else if (other.gameObject.CompareTag("Money"))
    {
      fireworksParticle.Play();
      playerAudio.PlayOneShot(moneySound, 1.0f);
      Destroy(other.gameObject);

    }

    else if (other.gameObject.CompareTag("Ground"))
    {
      fireworksParticle.Play();
      playerAudio.PlayOneShot(moneySound, 1.0f);
      playerRb.AddForce(0.5f * floatForce * Vector3.up, ForceMode.Impulse);

    }

  }

}
