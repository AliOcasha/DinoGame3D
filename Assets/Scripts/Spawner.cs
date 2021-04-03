using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ground;
    Vector3 nextSpawnPoint = new Vector3(49.5f, -0.9f, 0f);

    public void SpawnTile()
    {
        GameObject temp = Instantiate(Ground, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }

    }
}
