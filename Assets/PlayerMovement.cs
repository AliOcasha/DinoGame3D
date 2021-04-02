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
        transform.position = new Vector3(49.5f, 0f, 0f);
        transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
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
        if (transform.position.y <= 0.05 && transform.position.y >= -0.05)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerRb.AddForce(0f, 1000f, 0f);
            }
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
