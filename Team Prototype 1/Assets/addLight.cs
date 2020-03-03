using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addLight : MonoBehaviour
{
    public GameObject thecamera;
    public GameObject create;
    static public Queue<GameObject> lightCollection = new Queue<GameObject>(); 
    static public int lightCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = thecamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if(lightCount >= 3)
                {
                    Destroy(lightCollection.Dequeue());
                    lightCount -= 1;
                    if (addLight.lightCount < 0)
                    {
                        addLight.lightCount = 0;
                    }
                }
                lightCollection.Enqueue(GameObject.Instantiate(create, hit.point, Quaternion.identity));
                lightCount += 1;
            }
        }

    }
}
