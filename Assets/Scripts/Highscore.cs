using UnityEngine;
using UnityEngine.UI;


public class Highscore : MonoBehaviour
{
    public Score score;

    private Text Ausgabe;
    private void Start()
    {
        // Get Text Component
        Ausgabe = gameObject.GetComponent<Text>();
        // Set Text to current Highscore
        Ausgabe.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    private void Update()
    {
        // Saving Highscore in PlayerPrefs and displaying it
        if (score.score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", (int)score.score);
            Ausgabe.text = "Highscore: " + score.score.ToString("0");
        }
    }
}
