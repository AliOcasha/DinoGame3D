using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTiles : MonoBehaviour
{
    Spawner GroundSpawner;

    void Start()
    {
        GroundSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    void OnTriggerExit(Collider other)
    {
        // Spawning Tiles on Trigger
        GroundSpawner.SpawnTile();

        // Destroying them after player passed them
        Destroy(gameObject, 1);
    }
}
