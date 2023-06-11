using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] private path path;
    [SerializeField] private float movmentspeed = 1.0f;
    [SerializeField] GameObject muzzle;
    [SerializeField] GameObject shotVFX;
    [SerializeField] float showMINdelay = 1.0f;
    [SerializeField] float showMAXdelay = 12.0f;
    private Vector3 destination;
    
    int waypointIndex = 0;
    Boolean moveFlag = false;
    AudioSource muzzleAudio;

    private void Start()
    {
        muzzleAudio = muzzle.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(moveFlag==true)
        {
            destination = path.GetWayPoint(waypointIndex);
            transform.position = Vector3.Lerp(transform.position, destination, movmentspeed * Time.deltaTime);
        }
       
    }

    public void Advance(float maxDelay, float minDelay)
    {
        StartCoroutine(delayedAdvance(maxDelay, minDelay));
    }

    IEnumerator delayedAdvance(float maxDelay, float minDelay)
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(minDelay, maxDelay));
        if (moveFlag == false)
        {
            moveFlag = true;
            StartCoroutine(shotBehavior());
        }
            
        destination = path.GetWayPoint(waypointIndex);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(4.0f);
        GetComponent<AudioSource>().Pause();
    }

    IEnumerator shotBehavior()
    {
        while(true)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(showMINdelay, showMAXdelay));
            var myExplosion = Instantiate(shotVFX, muzzle.transform);
            muzzleAudio.Play();
            Destroy(myExplosion.gameObject, 1);
        }
    }
}
