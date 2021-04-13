using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public void Back()
    {
        gameObject.SetActive(false);
        MainMenu.SetActive(true);
    }
}
