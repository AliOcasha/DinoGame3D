using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Player;

    private Text Ausgabe;
    private RectTransform Transform;
    private PlayerMovement Movement;

    private bool GAMEOVER = false;
    private Color FontColorLose = new Color(140f, 16f, 14f, 255f);

    private void Start()
    {
        Ausgabe = gameObject.GetComponent<Text>();
        Transform = gameObject.GetComponent<RectTransform>();
        Movement = Player.GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        float Score = -Player.transform.position.x;
        Ausgabe.text = "SCORE: " + Score.ToString("0");
        if (Movement.enabled == false)
        {
            Ausgabe.color = FontColorLose;
            GAMEOVER = true;
        }
    }

    private void FixedUpdate()
    {
        if (GAMEOVER)
        {
            while (Transform.position.x <= 900)
            {
                Transform.Translate(Vector3.right / 50 * Time.deltaTime);
                Ausgabe.alignment = TextAnchor.MiddleCenter;
                Ausgabe.fontSize = 67 * 2;
            }
        }
    }
}
