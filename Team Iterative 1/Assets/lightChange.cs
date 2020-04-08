using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightChange : MonoBehaviour
{
    public GameObject thisLock;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (thisLock.tag == "unlocked")
        {
            this.gameObject.GetComponent<Light>().color = Color.green;
        }

    }
}