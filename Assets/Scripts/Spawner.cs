using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ground;
    public GameObject[] Obstacles;
    public GameObject Trigger;

    Vector3 nextSpawnPoint = new Vector3(0f, -0.9f, 0f);


    Vector3 O_nextSpawnPoint = new Vector3(-20f, 0.1f, 0f);
    Vector3 O_Pos;
    System.Random O_Typ = new System.Random();
    System.Random O_Count = new System.Random();
    System.Random Posi = new System.Random();
    GameObject Obstacle;

    public void SpawnTile()
    {
        // Tile Spawning
        GameObject Tile = Instantiate(Ground, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = Tile.transform.GetChild(1).transform.position;
    }

    // Obstacle Spawning
    public void SpawnObstacle()
    {
        int ObstacleType = O_Typ.Next(0,Obstacles.Length);
        int ObstacleCount = 1;
        if (ObstacleType == 3)
        {
            ObstacleCount = O_Count.Next(1, 4);
        }
        else
        {
            ObstacleCount = O_Count.Next(1, 6);
        }
        
        for (int i = 1; i <= ObstacleCount; i++)
        {
            int Pos = Posi.Next(-9, 9);
            O_Pos = new Vector3(O_nextSpawnPoint.x, O_nextSpawnPoint.y, Pos);
            Obstacle = Instantiate(Obstacles[ObstacleType], O_Pos, Quaternion.identity);
            if (i == ObstacleCount)
            {
                O_nextSpawnPoint = Obstacle.transform.position + new Vector3(-15f, 0f, 0f);
            }
        }
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
  