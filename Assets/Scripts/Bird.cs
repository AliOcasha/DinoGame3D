using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Spawner BirdSpawner;
    private readonly Quaternion BaseRot = Quaternion.Euler(0f, 90f, 0f);
    private readonly Vector3 Movement = Vector3.up * 1.5f;
    private void Start()
    {
        // Get Spawner Script
        BirdSpawner = GameObject.FindObjectOfType<Spawner>();
        // Set Rotation for Bird
        transform.rotation = BaseRot;
    }

    private void FixedUpdate()
    {
        // No Matter What KEEP PUSHING BACKWARDS
        gameObject.transform.Translate(Movement);
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
