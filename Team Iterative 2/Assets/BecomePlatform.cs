using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomePlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public Transform platform;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
                
            //Quaternion rotation = gameObject.transform.rotation;
            Vector3 position = gameObject.transform.position;
            Instantiate(platform, position, Quaternion.Euler(-90, 0, 0));
            Destroy(gameObject);

        }

    }
}
