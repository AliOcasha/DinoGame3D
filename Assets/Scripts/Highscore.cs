using UnityEngine;
using UnityEngine.UI;


public class Highscore : MonoBehaviour
{
    public Score score;

    private Text Ausgabe;

    private float highscore;
    private void Start()
    {
        Ausgabe = gameObject.GetComponent<Text>();
        Ausgabe.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    private void Update()
    {
        if (score.score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", (int)score.score);
            Ausgabe.text = "Highscore: " + score.score.ToString("0");
        }
    }
}
