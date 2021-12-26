using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables //
    public SFX Sfx;
    private Rigidbody PlayerRb;
    private bool Movement_x = false;
    private bool Jump = false;
    private float direction = 0;
    private Vector3 BasPos = new Vector3(0f, 0.8f, 0f);
    private Quaternion BasRot = Quaternion.Euler(-90f, 0f, 0f);
    private int Move_x;
    private readonly float Boundary = 12f;
    private readonly float JumpStrength = 1500f;
    private Vector3 side_Move;
    private Vector3 forward_Move = Vector3.left * 16.75f;
    private readonly float VelInc = 0.0004625f;
    private readonly float MaxSpeed = 40f;
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
        // Get Horizontal Input
        Move_x = (int)Input.GetAxisRaw("Horizontal");
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
        // Forbidding Mid-Air Jumps
        if (transform.position.y <= 0)
        {
            // Getting b
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Alpha8))
            {
                Jump = true;
                direction = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            Jump = true;
            direction = -0.25f;
        }
    }

    // Applying Physics and Movements
    private void FixedUpdate()
    {
        // Getting side Movement direction
        // Modifieng Mid-Air Movement
        if (transform.position.y <= 0)
        {  
            side_Move = Vector3.up * direction * 16.75f;
        }
        else
        {
            side_Move = Vector3.up * direction * 11.15f;
        }
        // Setting forward Movement Increase
        if (forward_Move.x <= MaxSpeed)
            forward_Move.x -= VelInc;
        // Movement, depending on Input, via Translation
        if (Movement_x == true)
            transform.Translate(side_Move * Time.deltaTime);  
        // Jump via Force
        else if (Jump == true)
        {
            PlayerRb.AddForce(0f, direction * JumpStrength * Time.deltaTime, 0f, ForceMode.Impulse);
            Jump = false;
        }
        // Boundaries on Ground
        if (transform.position.z <= -Boundary)
            transform.position = new Vector3(transform.position.x, transform.position.y, -Boundary);

        if (transform.position.z >= Boundary)
            transform.position = new Vector3(transform.position.x, transform.position.y, Boundary);
        // No Matter What KEEP PUSHING FORWARD
        transform.Translate(forward_Move * Time.deltaTime);
        // Playing StepSound
        Sfx.PlaySteps();
    }
}
