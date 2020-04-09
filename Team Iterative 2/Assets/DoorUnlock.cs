using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock: MonoBehaviour
{
    public GameObject thisLock;
    private Collider doorCollider;
    private MeshRenderer doorRender;
    // Start is called before the first frame update
    void Start()
    {
        doorCollider = GetComponent<Collider>();
        doorRender = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(thisLock.tag == "unlocked")
        {
            doorCollider.enabled = false;
            doorRender.enabled = false;
        }
    }
}
