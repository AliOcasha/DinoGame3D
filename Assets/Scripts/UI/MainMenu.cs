using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenu;
    private UIBackEnd BackEnd;

    private void Start()
    {
        BackEnd = gameObject.GetComponent<UIBackEnd>();
    }
    // Starting Game
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        gameObject.SetActive(true);
        OptionsMenu.SetActive(false);
    }
    // Quit Application ( works just in finished Build not in Editor)
    public void Quit()
    {
        BackEnd.SetQuality(2);
        gameObject.SetActive(true);
        OptionsMenu.SetActive(false);
        Application.Quit();
    }

    // Displaying OptionsMenu
    public void Options()
    {
        gameObject.SetActive(false);
        OptionsMenu.SetActive(true);
    }
}
