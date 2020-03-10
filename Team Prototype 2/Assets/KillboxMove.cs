using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillboxMove : MonoBehaviour
{
    private float speed = 0.5f;

    void FixedUpdate()
    {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Mode1"))
        {
            speed = 1.5f;
        } else if (other.CompareTag("Mode2"))
        {
            speed = 3f;
        }
    }

    private void OnTriggerExit(Collider other)
    { 
    if (other.CompareTag("Mode1"))
    {
        speed = 0.5f;
    } else if (other.CompareTag("Mode2"))
        {
            speed = 0.5f;
        }
}
}
