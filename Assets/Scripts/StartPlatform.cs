using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    // Deleting Starter Platform after 2 seconds
    void Start()
    {
        Destroy(gameObject, 2);
    }
}
