using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class sceneManager : MonoBehaviour
{

    [SerializeField] tankManager tankManager;
    [SerializeField] artilleryManager artilleryManager;
    [SerializeField] textManager textManager;
    [SerializeField] Vector2 raycast = new Vector2
    public GameObject battlefield;
    public Camera ARcamera;
    public ARRaycastManager raycastManager;

    private ARRaycastHit hit;

    private Boolean readyFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        while (!readyFlag)
        {

            //Ray ray = ARcamera.ScreenPointToRay(new Vector3(-0.5f, -0.5f, 0.0f));
            if (raycastManager.Raycast(ray, hit, TrackableType.Planes)
            {
                Pose pose= hit.pose;
                Instantiate(battlefield, pose.position, pose.rotation);
                readyFlag = true;
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
