using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Spawner ObstacleSpawner;

    void Start()
    {
        ObstacleSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    void OnTriggerExit(Collider other)
    {
        ObstacleSpawner.SpawnObstacle();

        Destroy(gameObject, 2);
    }


}
