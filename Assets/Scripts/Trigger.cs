using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Spawner TriggerSpawner;

    void Start()
    {
        TriggerSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    void OnTriggerExit(Collider other)
    {
        TriggerSpawner.SpawnObstacle();
        TriggerSpawner.SpawnTrigger();

        Destroy(gameObject, 2);
    }
}
