using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTiles : MonoBehaviour
{
    private Spawner GroundSpawner;

    private void Start()
    {
        // Get Spawn Script
        GroundSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    // When Ground Tile is passed
    void OnTriggerExit(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            // Spawning Tiles on Trigger
            GroundSpawner.SpawnTile();

            // Destroying them after player passed them
            Destroy(gameObject, 1);
        }

    }
}
