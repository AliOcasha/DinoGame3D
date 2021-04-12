using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject PauseButton;
    public Buttons Pause;

    private PlayerMovement Movement;
    private Animator Animator;

    private void Start()
    {
        // Getting PlayerMovement Script
        Movement = gameObject.GetComponent<PlayerMovement>();
        // Getting Animator Component
        Animator = gameObject.GetComponent<Animator>();
        // Enabling the Player Movement at Set Up and Animation
        Animator.SetBool("Walking", true);
        Movement.enabled = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        // If it collides it something other then the ground the PlayerMovement is disabled and the Animation stopped
        if (collision.collider.CompareTag("Obstacle"))
        {
            PauseButton.SetActive(false);
            Animator.SetBool("Walking", false);
            Movement.enabled = false;
            Pause.EnableMenu();
            
        }
    }
}
