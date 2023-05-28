using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artilleryManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] waves;

    private int i;

    public void nextWave()
    {
        waves[i].SetActive(true);
        i++;
    }


}
