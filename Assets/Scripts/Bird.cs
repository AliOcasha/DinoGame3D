using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Spawner BirdSpawner;

    private Vector3 Movement = Vector3.right * 25;
    private void Start()
    {
        // Get Spawner Script
        BirdSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    private void FixedUpdate()
    {
        // No Matter What KEEP PUSHING BACKWARDS
        gameObject.transform.Translate(Movement* Time.deltaTime);
    }
    // Spawn Bird after Passing Player and  Destroy this Bird 2 seconds after
    private void OnTriggerExit(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            BirdSpawner.SpawnBird();
            Destroy(gameObject, 2);
        }

    }
}
