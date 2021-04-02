using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody PlayerRb;
    public Transform Platform;

    bool Movement_x = false;
    bool Jump = false;
    int direction = 0;

    void Start()
    {
        // Player Set Up
        PlayerRb.freezeRotation = true;
        PlayerRb.mass = 3;
        PlayerRb.useGravity = true;

        transform.position = new Vector3(49.5f, 0f, 0f);
        transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
    }

    void FixedUpdate()
    {
        // Processing "Left/Right" Input
        int Move_x = (int)Input.GetAxisRaw("Horizontal");
        if (Move_x == 1)
        {
            Movement_x = true;
            direction = -1;
        }
        if (Move_x == -1)
        {
            Movement_x = true;
            direction = 1;
        }

        // Processing Spacebar Input and Forbidding Mid-Air Jumps
        if (transform.position.y <= 0.05 && transform.position.y >= -0.05)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump = true;
            }
        }




    }

    void Update()
    {
        // Movement, depending on Input, via Translation
        if (Movement_x == true)
        {
            transform.Translate(Vector3.up * direction / 4);
            Movement_x = false;
            direction = 0;
        }    
        
        // Jump via Force
        if (Jump == true)
        {
            PlayerRb.AddForce(0f, 1000f, 0f);
        }
        
        // Boundaries on Plane of Scale 2
        if (transform.position.z <= -9.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -9.5f);
        }
        if (transform.position.z >= 9.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 9.5f);
        }
    }
}
