using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    private TMP_Text Text;
    public Button PauseButton;
    private int Counter = 0;
    // Start is called before the first frame update
    private void Start()
    {
        Text = gameObject.GetComponent<TMP_Text>();
        Text.text = "3";
        PauseButton.interactable = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Counter < 60)
        {
            Text.text = "3";
        }
        else if (Counter == 60)
        {
            Text.text = "2";
        }
        else if (Counter == 120)
        {
            Text.text = "1";
        }
        else if (Counter > 180)
        {
            Destroy(gameObject);
            Time.timeScale = 1;
            PauseButton.interactable = true;
        }
        if (Counter <= 180)
        {
            Counter++;
        }
    }
}
