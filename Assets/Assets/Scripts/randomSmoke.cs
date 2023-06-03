using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSmoke : MonoBehaviour
{

    [SerializeField] float maxHight = 5.0f;
    [SerializeField] float minHight = 3.0f;
    [SerializeField] float maxWidth = 6.0f;
    [SerializeField] float minWidth = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localScale = new Vector3(UnityEngine.Random.Range(minWidth, maxWidth), UnityEngine.Random.Range(minHight, maxHight), 3.0f);
    }
}
