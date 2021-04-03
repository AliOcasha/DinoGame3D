using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject Ground;
    public PlayerMovement Movement;

    void Start()
    {
        // Enabling the Player Movement at Set Up
        Movement.enabled = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        // If it collides it something other then the ground the PlayerMovement is disabled
        if (collision.collider.tag != Ground.tag)
        {
            Movement.enabled = false;
        }
    }
}
