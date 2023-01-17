using System.Collections;
using UnityEngine;

public class PlayerControllerP4 : MonoBehaviour
{
  public float speed = 5.0f;
  public float powerupStrength = 10;
  public GameObject powerupIndicator;

  public bool hasPowerup;
  public static GameObject self;

  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("All Tags: " + string.Join(",", UnityEditorInternal.InternalEditorUtility.tags));
    Debug.Log("Player CurrentThread: " + System.Threading.Thread.CurrentThread.ManagedThreadId);
    rb = GetComponent<Rigidbody>();
    self = gameObject;
  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.y < -5)
    {
      Destroy(gameObject);
    }

    rb.AddForce(Input.GetAxis("Vertical") * speed * RotateCamera.focalPoint.transform.forward);

    powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Powerup"))
    {
      StartCoroutine(nameof(PowerupCountdownRoutine));
      Destroy(other.gameObject);
    }

  }

  private void OnCollisionEnter(Collision other)
  {
    if (hasPowerup && other.gameObject.CompareTag("Enemy"))
    {
      Rigidbody enemyRb = other.gameObject.GetComponent<Rigidbody>();
      Vector3 awayFromMe = other.gameObject.transform.position - transform.position;
      enemyRb.AddForce(awayFromMe * powerupStrength, ForceMode.Impulse);

    }
  }

  IEnumerator PowerupCountdownRoutine()
  {
    hasPowerup = true;
    powerupIndicator.SetActive(true);
    yield return new WaitForSeconds(5);
    hasPowerup = false;
    powerupIndicator.SetActive(false);
  }
}
