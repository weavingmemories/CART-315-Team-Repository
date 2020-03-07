using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decay : MonoBehaviour
{
    // public GameObject fairyLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float decayFactor = 1f / 600f;
        this.gameObject.GetComponent<Light>().intensity -= decayFactor ;
        if (this.gameObject.GetComponent<Light>().intensity <= 0.2f)
        {
            Destroy(addLight.lightCollection.Dequeue());
            addLight.lightCount -= 1;
            if (addLight.lightCount < 0)
            {
                addLight.lightCount = 0;
            }
        }
    }
}
