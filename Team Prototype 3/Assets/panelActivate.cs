using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelActivate : MonoBehaviour
{
    public GameObject lightBall;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Light>().color = Color.red;
    }

    // Update is called once per frame


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "lightBall")
        {
            this.gameObject.transform.tag = "unlocked";
            this.gameObject.GetComponent<Light>().intensity = 5;
            this.gameObject.GetComponent<Light>().color = Color.green;
            Debug.Log(this.gameObject.tag);
        }
    }

}
