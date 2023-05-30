using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class recordManager : MonoBehaviour
{
    

    public void PlayAudio()
    {
        GetComponent<AudioSource>().Play();
    }


}
