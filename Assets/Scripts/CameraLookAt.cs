using UnityEngine;
using System.Collections;


public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    Vector3 cameraP;

    void Update() //매프레임 마다
    {
        cameraP.x = target.position.x + 0f;
        cameraP.y = target.position.y + 5f;
        cameraP.z = target.position.z + -13f;

        transform.position = cameraP;
    }
}