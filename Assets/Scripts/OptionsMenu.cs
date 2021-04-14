using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject MainMenu;
    // Back to Main Menu on Startscreen
    public void Back()
    {
        gameObject.SetActive(false);
        MainMenu.SetActive(true);
    }
}
