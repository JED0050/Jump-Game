using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody PRigBody;

    private float speed = 0.01f;


    void Start()
    {
        PRigBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            PRigBody.velocity = new Vector3(0, 5, 0);
        }
        
        if (Input.GetKey("w"))
        {
            var position = GetComponent<Rigidbody>().position;
            PRigBody.position = new Vector3(position.x, position.y, position.z + speed);
        }
        else if (Input.GetKey("s"))
        {
            var position = GetComponent<Rigidbody>().position;
            PRigBody.position = new Vector3(position.x, position.y, position.z - speed);
        }

        if (Input.GetKey("a"))
        {
            var position = GetComponent<Rigidbody>().position;
            PRigBody.position = new Vector3(position.x - speed, position.y, position.z);
        }
        else if (Input.GetKey("d"))
        {
            var position = GetComponent<Rigidbody>().position;
            PRigBody.position = new Vector3(position.x + speed, position.y, position.z);
        }
    }
}
