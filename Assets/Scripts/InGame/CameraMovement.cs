using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;

    //Setting Set Up Variables for Rot and Pos
    public Vector3 Endoffset = new Vector3(4.4f, 3f, 0f);
    private Quaternion EndRot = Quaternion.Euler(13.7f, 270f, 0f);

    private void Start()
    {
        // Set Up Camera Rotation
        transform.rotation = EndRot;        
    }
    private void Update()
    {
        // Camera following Player
        transform.position = Target.transform.position + Endoffset;
    }
}
