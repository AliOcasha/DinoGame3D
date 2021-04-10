using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Setting Up Obstacle Position
    private void Start()
    {
        transform.rotation = Quaternion.Euler(-90f, 90f, 0f);
    }

    // Destroying Obstacle 30 seconds after Start
    private void Update()
    {
        Destroy(gameObject, 30);
    }


}
