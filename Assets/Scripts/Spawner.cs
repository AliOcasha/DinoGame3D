using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;

    Vector3 nextSpawnPoint = new Vector3(0f, -0.9f, 0f);
    Vector3 O_nextSpawnPoint = new Vector3(-20f, 0.1f, 0f);

    public void SpawnTile()
    {
        // Tile Spawning
        GameObject Tile = Instantiate(Ground, nextSpawnPoint, Quaternion.identity);
        // Setting new Spawnpoint of Tile and Obstacle
        nextSpawnPoint = Tile.transform.GetChild(1).transform.position;
    }

    // Obstacle Spawning
    public void SpawnObstacle()
    {
        GameObject Obstacle = Instantiate(Obstacle1, O_nextSpawnPoint, Quaternion.identity);
        O_nextSpawnPoint = Obstacle.transform.position + new Vector3(-20f, 0f, 0f);
    }

    void Start()
    {
        // Set Up Tiles
        for (int i = 0; i < 12; i++)
        {
            SpawnTile();
            SpawnObstacle();
        }


    }
}
  