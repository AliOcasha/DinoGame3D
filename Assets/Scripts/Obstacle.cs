using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Spawner ObstacleSpawner;
    private Quaternion BaseRot = Quaternion.Euler(-90f, 90f, 0f);
    
    private void Start()
    {
        ObstacleSpawner = GameObject.FindObjectOfType<Spawner>();
        // Setting Up Obstacle Position
        transform.rotation = BaseRot;
    }
    private void OnTriggerExit(Collider player)
    {
        // Spawning new Obstacles when Player exits Trigger and delete given one
        if (player.CompareTag("Player"))
        {
            ObstacleSpawner.SpawnObstacle();
            Destroy(gameObject, 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }


}
