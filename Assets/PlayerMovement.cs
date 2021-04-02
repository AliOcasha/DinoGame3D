using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody PlayerRb;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb.freezeRotation = true;
        PlayerRb.position = new Vector3(49.5f, 0f, 0f);
        PlayerRb.rotation = Quaternion.Euler(-90f, 0f, 0f);
    }

    void FixedUpdate()
    {
        int Move_x = (int)Input.GetAxisRaw("Horizontal");
        if (Move_x == 1)
        {
            transform.Translate(Vector3.down);
        }
        if (Move_x == -1)
        {
            transform.Translate(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Sprung");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
