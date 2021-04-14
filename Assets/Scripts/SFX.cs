using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource Steps;
    public AudioSource CactusCollision;

    // Playing Step Sound syncron to Dinosaur Animation
    public void PlaySteps()
    {
        if (Steps.isPlaying == false)
        {
            Steps.PlayDelayed(0.125f);
        }
    }
    // Instantly playing Collision Sound
    public void PlayCactusCollision()
    {
        if (CactusCollision.isPlaying == false)
        {
            CactusCollision.Play();
        }
    }
}
