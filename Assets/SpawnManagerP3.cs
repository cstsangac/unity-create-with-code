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
        Instantiate(obstaclePrefab, new Vector3(30, 0, 0), obstaclePrefab.transform.rotation);

        if (!PlayerControllerP3.gameOver) {
            Invoke(nameof(Spawn),Random.Range(1, repeat));
        }
    }
}
