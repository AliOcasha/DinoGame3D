using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody PlayerRb;
    private bool Movement_x = false;
    private bool Jump = false;
    private int direction = 0;
    private Vector3 BasPos = new Vector3(0f, 0.8f, 0f);
    private Quaternion BasRot = Quaternion.Euler(-90f, 0f, 0f);

    private void Start()
    {
        // Getting Rigidbody Component
        PlayerRb = gameObject.GetComponent<Rigidbody>();
        // Player Set Up
        PlayerRb.freezeRotation = true;
        PlayerRb.mass = 3;
        PlayerRb.useGravity = true;

        transform.position = BasPos;
        transform.rotation = BasRot;
    }

    // Processing Inputs
    private void Update()
    {
        // Getting Keyboard Input
        int Move_x = (int)Input.GetAxisRaw("Horizontal");
        // Forbidding Mid-Air Movement
        if (transform.position.y <= 0)
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
        }
    }

    // Applying Physics and Movements
    private void FixedUpdate()
    {
        float Boundary = 12f;
        float JumpStrength = 100000f;
        Vector3 side_Move = Vector3.up * direction * 18.75f;
        Vector3 forward_Move = Vector3.left * 18.75f;


        // Movement, depending on Input, via Translation
        if (Movement_x == true)
        {
            transform.Translate(side_Move * Time.deltaTime);
        }    
        
        // Jump via Force
        else if (Jump == true)
        {
            PlayerRb.AddForce(0f, JumpStrength * Time.deltaTime, 0f);
            Jump = false;
        }
        
        // Boundaries on Ground
        if (transform.position.z <= -Boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -Boundary);
        }
        if (transform.position.z >= Boundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Boundary);
        }
        // No Matter What KEEP PUSHING FORWARD
        transform.Translate(forward_Move * Time.deltaTime);
    }
}
