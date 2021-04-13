using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenu;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        gameObject.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        gameObject.SetActive(false);
        OptionsMenu.SetActive(true);
    }
}
