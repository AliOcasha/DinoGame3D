using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject Player;

    private Text Ausgabe;
    private float distance;

    private void Start()
    {
        // getting Text Object
        Ausgabe = gameObject.GetComponent<Text>();
    }
    private void Update()
    {
        // Setting Score depending on Player position
        distance = -Player.transform.position.x;
        Ausgabe.text = "Distance: " + distance.ToString("0") + " m";
    }
}
