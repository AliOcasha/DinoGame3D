using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Player;

    private Text Ausgabe;
    private float score;

    private void Start()
    {
        // getting Text Object
        Ausgabe = gameObject.GetComponent<Text>();
    }
    private void Update()
    {
        // Setting Score depending on Player position
        score = -Player.transform.position.x/3.5f;
        Ausgabe.text = "SCORE: " + score.ToString("0");
    }
}
