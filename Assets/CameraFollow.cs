using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.0125f;
    public Vector3 offset = new Vector3(100,0,0);

    void Update()
    {
        Vector3 desirePosition = target.position;// + offset;
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
        //transform.position = smoothPosition;

        transform.LookAt(target);
    }
}
