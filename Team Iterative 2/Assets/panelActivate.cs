using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelActivate : MonoBehaviour
{
    public GameObject lightBall;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touched");
        if (collision.gameObject.tag == "lightBall")
        {
            this.gameObject.transform.tag = "unlocked";
        }
    }

}
