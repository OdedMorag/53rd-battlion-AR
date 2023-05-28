using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodingObject : MonoBehaviour
{

    [SerializeField] GameObject explotionVFX;
    [SerializeField] AudioClip[] AudioClip;
    [SerializeField] float maxDelay = 6.0f;
    [SerializeField] float minDelay = 1.0f;

    
    
    private AudioSource src;

    private void Start()
    {
       
        int i = Random.Range(0, AudioClip.Length - 1 );
        float delay = Random.Range(minDelay, maxDelay);
        src = GetComponent<AudioSource>();
        src.clip = AudioClip[i];
        StartCoroutine(startAnimation(delay));
        
        

    }

    IEnumerator startAnimation(float delay)
    {
        yield return new WaitForSeconds(delay);
        this.GetComponentInChildren<MeshRenderer>().enabled = true;
        GetComponent<Animator>().enabled = true;
    }

    public void explode()
    {
        var myExplosion = Instantiate(explotionVFX, transform);
        src.Play();
        Destroy(myExplosion.gameObject, 2);
        
    }
}
