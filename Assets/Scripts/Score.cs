using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Player;

    private Text Ausgabe;

    private void Start()
    {
        Ausgabe = gameObject.GetComponent<Text>();
    }
    private void Update()
    {
        float Score = -Player.transform.position.x;
        Ausgabe.text = "SCORE: " + Score.ToString("0");
    }
}
