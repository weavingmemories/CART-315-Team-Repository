using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock: MonoBehaviour
{
    public GameObject thisLock;
    Collider doorCollider
    // Start is called before the first frame update
    void Start()
    {
        doorCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(thisLock.tag == "unlocked")
        {
            doorCollider.enabled = !m_Collider.enabled;
        }
    }
}
