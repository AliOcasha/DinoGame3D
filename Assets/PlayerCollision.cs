using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject Ground;
    public PlayerMovement Movement;

    void Start()
    {
        Movement.enabled = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != Ground.tag)
        {
            Movement.enabled = false;
        }
    }
}
