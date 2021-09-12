using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 vecToCamera = Camera.main.transform.position - transform.position;
        vecToCamera.y = 0.0f;
        transform.rotation = Quaternion.LookRotation(vecToCamera, Vector3.up);
    }
}
