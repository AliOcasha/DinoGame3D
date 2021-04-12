using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Spawner BirdSpawner;
    private Animator Animator;
    private readonly Quaternion BaseRot = Quaternion.Euler(-90f, 90f, 0f);
    private readonly Vector3 Movement = Vector3.down * 1.5f;
    private void Start()
    {
        // Get Spawner Script
        BirdSpawner = GameObject.FindObjectOfType<Spawner>();
        //Get Animator Component
        Animator = gameObject.GetComponent<Animator>();
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Animator.SetBool("Flying", false);
        }
        else
        {
            Animator.SetBool("Flying", true);
        }
    }
}