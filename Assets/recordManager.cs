using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class recordManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayAudio();
    }

    public AudioSource audioSource;

    public void PlayAudio()
    {
        audioSource.Play();
    }

    public void StopAudio()
    {
        audioSource.Stop();
    }
}
