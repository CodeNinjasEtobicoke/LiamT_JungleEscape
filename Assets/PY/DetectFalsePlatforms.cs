using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public float distance = 0.15f;
    bool hit;

    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, distance, 1 << 8);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        if (hit == false)
        {
            Debug.Log("All clear!");
        }
        else
        {
            Debug.LogWarning("Be careful!");
        }
    }
}
