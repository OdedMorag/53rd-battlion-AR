using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankManager : MonoBehaviour
{

    [SerializeField] mover[] tanks;

    public void advanceALL()
    {
        foreach(mover tank in tanks)
        {
            tank.Advance();
        }
    }

 
}
