using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource Steps;
    public AudioSource CactusCollision;

    public void PlaySteps()
    {
        if (Steps.isPlaying == false)
        {
            Steps.PlayDelayed(0.125f);
        }
    }

    public void PlayCactusCollision()
    {
        if (CactusCollision.isPlaying == false)
        {
            CactusCollision.Play();
        }
    }
}
