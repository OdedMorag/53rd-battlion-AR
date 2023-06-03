using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodingObject : MonoBehaviour
{

    [SerializeField] GameObject explotionVFX;
    [SerializeField] GameObject smokeVFX;
    [SerializeField] AudioClip[] AudioClip;
    [SerializeField] GameObject body;
    [SerializeField] Boolean leaveSmoke;
    
    
    private AudioSource src;
    private LODGroup LODGroup;
    private float maxDelay = 6.0f;
    private float minDelay = 1.0f;

    

    public void setBomb(float max,float min)
    {
        maxDelay = max;
        minDelay = min;
        int i = UnityEngine.Random.Range(0, AudioClip.Length - 1 );
        float delay = UnityEngine.Random.Range(minDelay, maxDelay);
        src = GetComponent<AudioSource>();
        src.clip = AudioClip[i];
        StartCoroutine(startAnimation(delay));

    }



    IEnumerator startAnimation(float delay)
    {
        yield return new WaitForSeconds(delay);
        body.SetActive(true); 
        GetComponent<Animator>().enabled = true;
        
    }

    public void explode()
    {
        body.SetActive(false);
        var myExplosion = Instantiate(explotionVFX, transform);
        if (leaveSmoke) 
        {
            Instantiate(smokeVFX, transform);
        }
        src.Play();
        Destroy(myExplosion.gameObject, 2);
        if(!leaveSmoke)
        {
            Destroy(gameObject, 3);
        }
        
    }


    private void OnDrawGizmos()
    {
        if (leaveSmoke)
            Gizmos.color = Color.red;
        else
            Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, 2f);
    }
}
