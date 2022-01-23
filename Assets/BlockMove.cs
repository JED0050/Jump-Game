using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    public Vector3 speedV;

    private int counter;
    public int counterMax = 2000;
    private bool sameDir = true;

    void Start()
    {
        counter = counterMax / 2;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if(counter > counterMax)
        {
            counter = 0;
            sameDir = !sameDir;
        }

        var position = transform.position;

        if(sameDir)
        {
            transform.position = new Vector3(position.x + speedV.x, position.y + speedV.y, position.z + speedV.z);
        }
        else
        {
            transform.position = new Vector3(position.x - speedV.x, position.y - speedV.y, position.z - speedV.z);
        }
    }
}
