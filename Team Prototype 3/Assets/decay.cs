using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decay : MonoBehaviour
{
    //public GameObject fairyLight;


    // Update is called once per frame
    void FixedUpdate()
    {
        float decayFactor = 1f / 50f;
        this.gameObject.GetComponent<Light>().intensity -= decayFactor ;
        if (this.gameObject.GetComponent<Light>().intensity <= 0.01f)
        {
            Destroy(this.gameObject);
        }
    }
}
