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

    Vector3 BasPos = new Vector3(49.5f, 0f, 0f);
    Quaternion BasRot = Quaternion.Euler(-90f, 0f, 0f);

    void Start()
    {
        // Player Set Up
        PlayerRb.freezeRotation = true;
        PlayerRb.mass = 3;
        PlayerRb.useGravity = true;

        transform.position = BasPos;
        transform.rotation = BasRot;
    }

    void FixedUpdate()
    {
        int Move_x = (int)Input.GetAxisRaw("Horizontal");
        if (transform.position.y <= 0.05 && transform.position.y >= -0.05)
        {  
            //Processing Horizontal Input
            if (Move_x == 1)
            {
                Movement_x = true;
                direction = -1;
            }
            else if (Move_x == -1)
            {
                Movement_x = true;
                direction = 1;
            }
            else
            {
                 Movement_x = false;
                 direction = 0;
            }        
       
            // Processing Spacebar Input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump = true;
            }
            else
            {
                Jump = false;
            }
        }
    }

    void Update()
    {
        float Boundary = 9.5f;
        float JumpStrength = 1000f;
        Vector3 Move = Vector3.up * direction / 4;

        // Movement, depending on Input, via Translation
        if (Movement_x == true)
        {
            transform.Translate(Move);
        }    
        
        // Jump via Force
        else if (Jump == true)
        {
            PlayerRb.AddForce(0f, JumpStrength, 0f);
        }
        
        // Boundaries on Plane of Scale 2
        if (transform.position.z <= -Boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -Boundary);
        }
        if (transform.position.z >= Boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Boundary);
        }
    }
}
