using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    public GameObject Spawner;
    void FixedUpdate()
    {
        transform.Translate(Vector3.right/4);

        if (transform.position.x >= 150)
        {
            Destroy(gameObject);
        }
    }
}
