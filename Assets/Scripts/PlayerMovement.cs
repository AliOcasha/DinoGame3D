using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SFX Sfx;
    private Rigidbody PlayerRb;
    private bool Movement_x = false;
    private bool Jump = false;
    private int direction = 0;
    private Vector3 BasPos = new Vector3(0f, 0.8f, 0f);
    private Quaternion BasRot = Quaternion.Euler(-90f, 0f, 0f);
    private readonly int Move_x = (int)Input.GetAxisRaw("Horizontal");
    private readonly float Boundary = 12f;
    private readonly float JumpStrength = 1500f;
    private Vector3 side_Move;
    private Vector3 forward_Move = Vector3.left * 18.75f;
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
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Alpha8))
            {
                Jump = true;
            }
        }
    }

    // Applying Physics and Movements
    private void FixedUpdate()
    {
        // Getting side Movement direction
         side_Move = Vector3.up * direction * 18.75f;
        // Movement, depending on Input, via Translation
        if (Movement_x == true)
        {
            transform.Translate(side_Move * Time.deltaTime);
        }    
        // Jump via Force
        else if (Jump == true)
        {
            PlayerRb.AddForce(0f, JumpStrength * Time.deltaTime, 0f, ForceMode.Impulse);
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
        // Playing StepSound
        Sfx.PlaySteps();
    }
}
