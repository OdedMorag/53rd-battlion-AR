using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artilleryManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] waves;

    private int i;


    private void Start()
    {
        //for(i =0;  i< waves.Length;  i++)
        //    waves[i].SetActive(false);
       // i = 0;
    }


    public void nextWave()
    {
        waves[i].SetActive(true);
        i++;
    }


}
