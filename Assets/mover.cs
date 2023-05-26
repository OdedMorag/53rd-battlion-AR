using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] private path path;
    [SerializeField] private float movmentspeed = 1.0f;
    private Vector3 destination;
    
    int waypointIndex = 0;
    Boolean moveFlag = false;

    private void Update()
    {
        if(moveFlag==true)
        {
            destination = path.GetWayPoint(waypointIndex);
            transform.position = Vector3.Lerp(transform.position, destination, movmentspeed * Time.deltaTime);
        }
       
    }

    public void Advance()
    {
        if (moveFlag == false) 
            moveFlag = true;
        destination = path.GetWayPoint(waypointIndex);
    }
}