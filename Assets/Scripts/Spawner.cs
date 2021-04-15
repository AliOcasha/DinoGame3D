using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ground;
    public GameObject[] Obstacles;
    public GameObject Bird;
    public GameObject Player;

    private readonly int Boundary = 11;
    private readonly float[] BirdSpawnStart = { -500f, -500.5f };

    private Vector3 nextSpawnPoint = Vector3.zero;
    private Vector3 O_nextSpawnPoint = new Vector3(-60f, 0f, 0f);
    private Vector3 B_nextSpawnPoint = new Vector3 (-1000f, 6f, 0f);
    private Vector3 O_Offset = new Vector3(-5f, 0f, 0f);
    private Vector3 B_Offset = new Vector3(-500f, 0f, 0f);

    private readonly System.Random O_Typ = new System.Random();
    private readonly System.Random O_Count = new System.Random();
    private readonly System.Random Posi = new System.Random();
    private readonly System.Random PosB = new System.Random();
    private readonly System.Random B_Count = new System.Random();

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
        if (ObstacleType == 4)
        {
            ObstacleCount = O_Count.Next(3, 6);
        }
        else
        {
            ObstacleCount = O_Count.Next(4, 8);
        }
        
        // Spawning Obstacles in current Line on random positions
        for (int i = 1; i <= ObstacleCount; i++)
        {
            int Pos = Posi.Next(-Boundary, Boundary);
            O_Pos = new Vector3(O_nextSpawnPoint.x, O_nextSpawnPoint.y, Pos);
            Obstacle = Instantiate(Obstacles[ObstacleType], O_Pos, Quaternion.identity);
            // Only changing Spawnpoint after every obstacle is placed
            if (i == ObstacleCount)
            {
                O_nextSpawnPoint = Obstacle.transform.position + O_Offset;
            }
        }
    }

    //Bird Spawning
    public void SpawnBird()
    {
        GameObject Vogel;
        Vector3 B_Pos;
        int BirdCount = B_Count.Next(1, 6);
        for (int i = 1; i <= BirdCount; i++)
        {
            int Pos = PosB.Next(-Boundary, Boundary);
            B_Pos = new Vector3(B_nextSpawnPoint.x, B_nextSpawnPoint.y, Pos);
            Vogel = Instantiate(Bird, B_Pos, Quaternion.identity);
            // Only changing Spawnpoint after every bird is placed
            if (i == BirdCount)
            {
                B_nextSpawnPoint = Vogel.transform.position + B_Offset;
            }
        }
    }

    private void Start()
    {
        // Set Up Starting Tiles and Obstacles
        for (int i = 0; i < 24; i++)
        {
            SpawnTile();
            SpawnObstacle();
        }
    }

    // Allow Bird Spawning after given Point and moving Spawner with Player
    private void FixedUpdate()
    {
        if (Player.transform.position.x <= BirdSpawnStart[0] && Player.transform.position.x >= BirdSpawnStart[1])
        {
            SpawnBird();
        }
        transform.position = Player.transform.position;
    }
}
  