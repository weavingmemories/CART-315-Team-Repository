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
    public int collisionCount = 0;
    public bool deactivate = false;
    public Material deadMaterial;
    static public Queue<GameObject> platformCollection = new Queue<GameObject>();


    void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        if (collisionCount >= 4)
        {
            this.gameObject.GetComponent<Light>().intensity = 0;
            deactivate = true;
            gameObject.GetComponent<MeshRenderer>().material = deadMaterial;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (deactivate == false)
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (collisionCount < 4)
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
