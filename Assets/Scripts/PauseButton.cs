using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public Spawner Spawner;
    public PlayerMovement Player;
    public Animator PlayerAnimation;
    public Text score;
    public void Pause()
    {
        if (Spawner.enabled)
        {
            Spawner.enabled = false;
            Player.enabled = false;
            PlayerAnimation.enabled = false;
        }
        else
        {
            Spawner.enabled = true;
            Player.enabled = true;
            PlayerAnimation.enabled = true;
            score.color = new Color(22f, 9f, 9f, 255f);
        }

    }
}
