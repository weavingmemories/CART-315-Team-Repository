using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapMove : MonoBehaviour
{
    public float minispeed = 0.5f;

    void FixedUpdate()
    {
        minispeed = GameObject.Find("Killbox").GetComponent<KillboxMove>().speed; ;

        transform.Translate(Vector2.up * minispeed * Time.deltaTime);
    }
}
