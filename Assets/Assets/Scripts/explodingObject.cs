using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodingObject : MonoBehaviour
{

    [SerializeField] GameObject explotionVFX;
    [SerializeField] GameObject smokeVFX;
    [SerializeField] AudioClip[] AudioClip;
    [SerializeField] float maxDelay = 6.0f;
    [SerializeField] float minDelay = 1.0f;
    [SerializeField] GameObject body;
    
    
    private AudioSource src;
    private LODGroup LODGroup;

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
        body.SetActive(true); 
        GetComponent<Animator>().enabled = true;
        
    }

    public void explode()
    {
        body.SetActive(false);
        var myExplosion = Instantiate(explotionVFX, transform);
        Instantiate(smokeVFX, transform);
        src.Play();
        Destroy(myExplosion.gameObject, 2);
        
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 1f);
    }
}
