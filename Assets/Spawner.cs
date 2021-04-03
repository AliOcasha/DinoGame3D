using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ground;

    void Start()
    {
        Instantiate(Ground);
        Ground.transform.position = new Vector3(-49f, -0.87f, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
    }
}
