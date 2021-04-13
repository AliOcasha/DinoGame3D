using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public PlayerMovement Player;
    public GameObject InGameMenu;
    public UIBackEnd BackEnd;
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

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


}
