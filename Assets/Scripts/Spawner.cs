using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;
    public GameObject Trigger;

    Vector3 nextSpawnPoint = new Vector3(0f, -0.9f, 0f);
    Vector3 O_nextSpawnPoint = new Vector3(-20f, 0.1f, 0f);
    GameObject Chosen;

    public void SpawnTile()
    {
        // Tile Spawning
        GameObject Tile = Instantiate(Ground, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = Tile.transform.GetChild(1).transform.position;
    }

    // Obstacle Spawning
    public void SpawnObstacle()
    {
        System.Random R = new System.Random();
        int ObstacleType = R.Next(1, 4);
        switch(ObstacleType)
        {
            case 1:
                Chosen = Obstacle1;
                break;
            case 2:
                Chosen = Obstacle2;
                break;
            case 3:
                Chosen = Obstacle3;
                break;
            default:
                Chosen = Obstacle1;
                break;

        }
        GameObject Obstacle = Instantiate(Chosen, O_nextSpawnPoint, Quaternion.identity);
        O_nextSpawnPoint = Obstacle.transform.position + new Vector3(-20f, 0f, 0f);
    }

    public void SpawnTrigger()
    {
        Instantiate(Trigger, O_nextSpawnPoint, Quaternion.identity);
    }

    void Start()
    {
        // Set Up Tiles
        for (int i = 0; i < 12; i++)
        {
            SpawnTile();
            SpawnObstacle();
            SpawnTrigger();
        }


    }
}
  