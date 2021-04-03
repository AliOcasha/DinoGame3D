using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTiles : MonoBehaviour
{
    Spawner GroundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        GroundSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    void OnTriggerExit(Collider other)
    {
        GroundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
