using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitch : MonoBehaviour
{
    public GameObject Terrain1;
    public GameObject Terrain2;
    public Light Light1;
    public Light Light2;
    public bool terrain1Active = true;
    public bool terrain2Active = false;
    public bool nightmode = false;

    // Start is called before the first frame update
    void Start()
    {
        Terrain t1 = Terrain1.gameObject.GetComponent<Terrain>();
        t1.enabled = true;
        Collider cr1 = Terrain1.gameObject.GetComponent<TerrainCollider>();
        cr1.enabled = true;

        Light l1 = Light1.gameObject.GetComponent<Light>();
        l1.enabled = true;

        Terrain t2 = Terrain2.gameObject.GetComponent<Terrain>();
        t2.enabled = false;
        Collider cr2 = Terrain2.gameObject.GetComponent<TerrainCollider>();
        cr2.enabled = false;

        Light l2 = Light2.gameObject.GetComponent<Light>();
        l2.enabled = false;

        terrain1Active = true;
        terrain2Active = false;
        nightmode = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            if (terrain1Active == true && terrain2Active == false)
            {
                Terrain t1 = Terrain1.gameObject.GetComponent<Terrain>();
                t1.enabled = false;
                Collider cr1 = Terrain1.gameObject.GetComponent<TerrainCollider>();
                cr1.enabled = false;

                Light l1 = Light1.gameObject.GetComponent<Light>();
                l1.enabled = false;

                Terrain t2 = Terrain2.gameObject.GetComponent<Terrain>();
                t2.enabled = true;
                Collider cr2 = Terrain2.gameObject.GetComponent<TerrainCollider>();
                cr2.enabled = true;

                Light l2 = Light2.gameObject.GetComponent<Light>();
                l2.enabled = true;

                terrain1Active = false;
                terrain2Active = true;
                nightmode = true;
            }
            else if (terrain1Active == false && terrain2Active == true)
            {
                Terrain t1 = Terrain1.gameObject.GetComponent<Terrain>();
                t1.enabled = true;
                Collider cr1 = Terrain1.gameObject.GetComponent<TerrainCollider>();
                cr1.enabled = true;

                Light l1 = Light1.gameObject.GetComponent<Light>();
                l1.enabled = true;

                Terrain t2 = Terrain2.gameObject.GetComponent<Terrain>();
                t2.enabled = false;
                Collider cr2 = Terrain2.gameObject.GetComponent<TerrainCollider>();
                cr2.enabled = false;

                Light l2 = Light2.gameObject.GetComponent<Light>();
                l2.enabled = false;

                terrain1Active = true;
                terrain2Active = false;
                nightmode = false;
            }
        }
    }
}
