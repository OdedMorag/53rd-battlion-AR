using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankManager : MonoBehaviour
{

    [SerializeField] mover[] tanks;
    [SerializeField] float maxDelayForTanks = 5.0f;
    [SerializeField] float minDelayForTanks = 1.0f;

    public void advanceALL()
    {
        foreach(mover tank in tanks)
        {
            tank.Advance(maxDelayForTanks,minDelayForTanks);
        }
    }

 
}
