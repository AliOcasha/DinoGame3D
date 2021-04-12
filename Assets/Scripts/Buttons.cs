using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public PlayerMovement Player;
    public GameObject InGameMenu;
    public void Pause()
    {
        if (Player.enabled)
        {
            Time.timeScale = 0;
            Player.enabled = false;
            EnableMenu();
        }
        else
        {
            Time.timeScale = 1;
            InGameMenu.SetActive(false);
            Player.enabled = true;
        }
        //if (Spawner.enabled)
        //{
        //    Spawner.enabled = false;
        //    Player.enabled = false;
        //    PlayerAnimation.enabled = false;
        //    InGameMenu.SetActive(true);
        //}
        //else
        //{
        //    Spawner.enabled = true;
        //    Player.enabled = true;
        //    PlayerAnimation.enabled = true;
        //    InGameMenu.SetActive(false);
        //}

    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void EnableMenu()
    {
        InGameMenu.SetActive(true);
    }
}
