using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ground;
    public GameObject[] Obstacles;
    public GameObject Trigger;

    private Vector3 nextSpawnPoint = new Vector3(0f, -0.9f, 0f);
    private Vector3 O_nextSpawnPoint = new Vector3(-60f, -0.9f, 0f);

    private readonly System.Random O_Typ = new System.Random();
    private readonly System.Random O_Count = new System.Random();
    private readonly System.Random Posi = new System.Random();
    
    // Tile Spawning
    public void SpawnTile()
    {
        // Tile Spawning
        GameObject Tile = Instantiate(Ground, nextSpawnPoint, Quaternion.identity);
        // Setting next Tile SpawnPoint
        nextSpawnPoint = Tile.transform.GetChild(1).transform.position;
    }

    // Obstacle Spawning
    public void SpawnObstacle()
    {
        GameObject Obstacle;    
        Vector3 O_Pos;



        int ObstacleType = O_Typ.Next(0,Obstacles.Length);
        int ObstacleCount;

        // Setting Amount of Obstacles in a Line depending on Type
        if (ObstacleType == 3)
        {
            ObstacleCount = O_Count.Next(1, 4);
        }
        else
        {
            ObstacleCount = O_Count.Next(1, 6);
        }
        
        // Spawning Obstacles in current Line on random positions
        for (int i = 1; i <= ObstacleCount; i++)
        {
            int Pos = Posi.Next(-9, 9);
            O_Pos = new Vector3(O_nextSpawnPoint.x, O_nextSpawnPoint.y, Pos);
            Obstacle = Instantiate(Obstacles[ObstacleType], O_Pos, Quaternion.identity);

            // Only changing Spawnpoint after every obstacle is placed
            if (i == ObstacleCount)
            {
                O_nextSpawnPoint = Obstacle.transform.position + new Vector3(-15f, 0f, 0f);
            }
        }
    }

    //Trigger Spawning on Same Position as a Obstacle Line
    public void SpawnTrigger()
    {
        Instantiate(Trigger, nextSpawnPoint, Quaternion.identity);
    }

    private void Start()
    {
        // Set Up Tiles, Obstacles and Triggers
        for (int i = 0; i < 12; i++)
        {
            SpawnTile();
            SpawnObstacle();
            SpawnTrigger();
        }
    }
}
  