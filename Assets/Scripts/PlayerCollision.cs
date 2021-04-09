using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerMovement Movement;

    private void Start()
    {
        // Getting PlayerMovement Script
        Movement = gameObject.GetComponent<PlayerMovement>();
        // Enabling the Player Movement at Set Up
        Movement.enabled = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        // If it collides it something other then the ground the PlayerMovement is disabled
        if (collision.collider.tag == "Obstacle")
        {
            Movement.enabled = false;
        }
    }
}
