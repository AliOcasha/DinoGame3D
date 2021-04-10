using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Spawner BirdSpawner;
    // Start is called before the first frame update
    private void Start()
    {
        BirdSpawner = GameObject.FindObjectOfType<Spawner>();
    }

    private void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.right * 25 * Time.deltaTime);
    }
    // Update is called once per frame
    private void OnTriggerExit(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            BirdSpawner.SpawnBird();
            Destroy(gameObject, 2);
        }

    }
}
