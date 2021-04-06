using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 90f, 0f);
    }

    void Update()
    {
        Destroy(gameObject, 30);
    }


}
