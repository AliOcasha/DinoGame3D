using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Spawner ObstacleSpawner;
    
    private void Start()
    {
        ObstacleSpawner = GameObject.FindObjectOfType<Spawner>();
        // Setting Up Obstacle Position
        transform.rotation = Quaternion.Euler(-90f, 90f, 0f);
    }
    private void OnTriggerExit(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            ObstacleSpawner.SpawnObstacle();
            Destroy(gameObject, 2);
        }
    }


}
