using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerP3 : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float repeat = 3;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Spawn),1);
        
    }

    void Spawn() {
        if (PlayerControllerP3.gameOver) {
            return;
        }
        Instantiate(obstaclePrefab, new Vector3(30, 0, 0), obstaclePrefab.transform.rotation);

        Invoke(nameof(Spawn),Random.Range(1, repeat));
    }
}
