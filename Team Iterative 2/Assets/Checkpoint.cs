using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] public Transform respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            respawnPoint = this.gameObject.transform;
        }
    }
}
