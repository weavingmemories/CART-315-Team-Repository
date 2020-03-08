using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillboxMove : MonoBehaviour
{
    private float speed;
    bool mode1Speed;
    bool mode2Speed;

    private void Start()
    {
        mode1Speed = true;
        mode2Speed = false;
    }

    void FixedUpdate()
    {
        if (mode1Speed == true && mode2Speed == false)
        {
            transform.Translate(Vector2.up * 0.2f * Time.deltaTime);
        }

        if (mode2Speed == true && mode1Speed == false)
        {
            transform.Translate(Vector2.up * 5f * Time.deltaTime);
        }
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mode1"))
        {
            mode1Speed = true;
            mode2Speed = false;
        }
        else if (other.CompareTag("Mode2"))
        {
            mode1Speed = false;
            mode2Speed = true;
        }
    }
}
