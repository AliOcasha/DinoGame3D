using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public Spawner Spawner;
    public PlayerMovement Player;
    public Animator PlayerAnimation;
    public GameObject InGameMenu;
    public void Pause()
    {
        if (Spawner.enabled)
        {
            Spawner.enabled = false;
            Player.enabled = false;
            PlayerAnimation.enabled = false;
            InGameMenu.SetActive(true);
        }
        else
        {
            Spawner.enabled = true;
            Player.enabled = true;
            PlayerAnimation.enabled = true;
            InGameMenu.SetActive(false);
        }

    }
}
