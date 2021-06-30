using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public Button PauseButton;

    private TMP_Text Text;
    private int Counter = 0;
    private void Start()
    {
        // Get Text Object // TextMesh Pro
        Text = gameObject.GetComponent<TMP_Text>();
        //Show 3 at First and disable Pause Button from being clickable
        Text.text = "3";
        PauseButton.interactable = false;
    }

    // Counting Down every 60 Frames until 3 seconds pass and destroy the Countdown Text Object
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
