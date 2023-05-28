using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    const float waypointgizmosradius = 1f;

    private void OnDrawGizmos()
    {
        
        for(int i = 0; i < transform.childCount; i++)
        {
            int j = i+1;
            Gizmos.DrawSphere(transform.GetChild(i).position, waypointgizmosradius);
            if (j < transform.childCount)
                Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(j).position);
        }
    }

    public Vector3 GetWayPoint(int i)
    {
        return transform.GetChild(i).position;
    }
}
