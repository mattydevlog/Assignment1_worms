using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform hp;

    float rotationSpeed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        hp.transform.Rotate(0, 1 * rotationSpeed, 0);
    }
}