using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public Transform platform;
    public int collisionCount = 0;
    public bool deactivate = false;
    public Material deadMaterial;


    void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        if (collisionCount >= 4)
        {
            deactivate = true;
            gameObject.GetComponent<MeshRenderer>().material = deadMaterial;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(deactivate == false)
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (collisionCount > 1 && collisionCount < 4)
                {
                    Quaternion rotation = gameObject.transform.rotation;
                    Vector3 position = gameObject.transform.position;
                    Instantiate(platform, position, rotation);
                    Destroy(gameObject);
                }
                
            }
        }
       
    }
}
