using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodingObject : MonoBehaviour
{

    [SerializeField] GameObject explotionVFX;

    public void explode()
    {
        var myExplosion = Instantiate(explotionVFX, transform);
        Destroy(myExplosion.gameObject, 2);
    }
}
