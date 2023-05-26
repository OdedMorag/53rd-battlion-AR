using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class sceneManager : MonoBehaviour
{

    [SerializeField] tankManager tankManager;
    [SerializeField] artilleryManager artilleryManager;
    [SerializeField] textManager textManager;
    
    public Camera ARcamera;
    public ARRaycastManager raycastManager;


    private Boolean readyFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        while (!readyFlag)
        {
            Ray ray = ARcamera.ScreenPointToRay(new Vector3(-0.5f, -0.5f, 0.0f));
            if()
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
