using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public SFX Sfx;
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
        // If it collides
        if (collision.collider.CompareTag("Obstacle"))
        {
            // UI is deactivated
            PauseButton.SetActive(false);
            // Stoping Dinosaur and Collision Sound
            Animator.SetBool("Walking", false);
            Sfx.PlayCactusCollision();
            Movement.enabled = false;
            // Enabling Menu
            Pause.EnableMenu();
        }
    }
}
