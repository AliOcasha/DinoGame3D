using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private Spawner TriggerSpawner;

    private void Start()
    {
        // Get Spawn Script
        TriggerSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    // When Trigger Object is passed
    private void OnTriggerExit(Collider other)
    {
        // Spawn a new Obstacle and Trigger
        TriggerSpawner.SpawnObstacle();
        TriggerSpawner.SpawnTrigger();
        // Destroy the current Obstacle 2 seconds after
        Destroy(gameObject, 2);
    }
}
