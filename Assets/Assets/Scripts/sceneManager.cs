using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TextManager;

public class sceneManager : MonoBehaviour
{

    [SerializeField] tankManager tankManager;
    [SerializeField] artilleryManager artilleryManager;
    [SerializeField] informationTextManager textManager;
    [SerializeField] recordManager recordManager;
    [SerializeField] GameObject skipButton;
    public ARRaycastManager raycastManager;
    private Coroutine coINFO;
    private ARRaycastHit hit;

    private Boolean readyFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        coINFO = StartCoroutine(showInfoText());
        //StartCoroutine(setBattlefield());
    }

    public void stopInfo()
    {
        textManager.clearText();
        StopCoroutine(coINFO);
        StartCoroutine(phase1());
    }



    IEnumerator showInfoText()
    {
        if (!informationTextManager.clickFlag)
        {
            for (int i = 0; i < textManager.textLen(); i++)
            {
                yield return new WaitForSeconds(4.5f);
                if (informationTextManager.clickFlag)
                    break;
                else textManager.NextText();
            }
        }
        //yield return new WaitForSeconds(3);
        StartCoroutine(phase1());

    }


    IEnumerator phase1()
    {
        skipButton.SetActive(false);
        artilleryManager.nextWave();
        yield return new WaitForSeconds(8);
        tankManager.gameObject.SetActive(true);
        recordManager.PlayAudio();
        tankManager.advanceALL();
        StartCoroutine(phase2());
    }

    IEnumerator phase2()
    {
        yield return new WaitForSeconds(30);
        artilleryManager.nextWave();
        tankManager.advanceALL();
    }

/*    IEnumerator setBattlefield()
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
        //StartCoroutine(showInfoText());*//*
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
