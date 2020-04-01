using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUnlock : MonoBehaviour
{
    public GameObject thisLock;
    private Collider platformCollider;
    private MeshRenderer platformRender;
    // Start is called before the first frame update
    void Start()
    {
        platformCollider = GetComponent<Collider>();
        platformRender = GetComponent<MeshRenderer>();
        platformCollider.enabled = false;
        platformRender.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (thisLock.tag == "unlocked")
        {
            platformCollider.enabled = true;
            platformRender.enabled = true;
        }
    }
}
