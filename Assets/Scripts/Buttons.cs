using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public PlayerMovement Player;
    public GameObject InGameMenu;
    public UIBackEnd BackEnd;
    // Pausing Game and enabling InGame Menu
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
    // Reloading Scene
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    // Enabling InGame Menu
    public void EnableMenu()
    {
        InGameMenu.SetActive(true);
    }
    // Back to Start Menu
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Start Game Paused
    private void Start()
    {
        Time.timeScale = 0;
    }

    // Hook ESC Key with Pause Function
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
}
