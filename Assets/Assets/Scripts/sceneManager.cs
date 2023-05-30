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
    [SerializeField] GameObject battlefield;

    public ARRaycastManager raycastManager;

    private ARRaycastHit hit;

    private Boolean readyFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(phase1());
    }


    IEnumerator phase1()
    {
        yield return new WaitForSeconds(4);
        artilleryManager.nextWave();
        yield return new WaitForSeconds(6);
        tankManager.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        tankManager.advanceALL();
    }

    IEnumerator setBattlefield()
    {
        yield return new WaitForSeconds(3);
        Vector2 rayPos = Camera.main.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(rayPos, hits, TrackableType.Planes);
        if (hits.Count > 0)
        {
            Pose hitpose = hits[0].pose;
            Instantiate(battlefield, hitpose.position, hitpose.rotation);
            readyFlag = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
