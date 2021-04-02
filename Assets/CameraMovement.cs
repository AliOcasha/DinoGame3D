using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset = new Vector3(4.4f, 1.85f, 0f);

    Quaternion BasRot = Quaternion.Euler(13.687f, -90f, 0f);
    void Update()
    {
        transform.position = Target.transform.position + offset;
        transform.rotation = BasRot;
    }
}
