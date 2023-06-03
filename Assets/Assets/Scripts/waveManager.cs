using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveManager : MonoBehaviour
{
    [SerializeField] float maxDelay = 6.0f;
    [SerializeField] float minDelay = 1.0f;


    void Start()
    {
        foreach (Transform child in gameObject.transform)
        { 
            explodingObject exp = child.GetComponent<explodingObject>();
            exp.setBomb(maxDelay, minDelay);
        }
    }

  
}
