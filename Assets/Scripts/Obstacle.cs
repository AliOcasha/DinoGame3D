using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject Player;

    void Update()
    {
        Destroy(gameObject, 30);
    }


}
