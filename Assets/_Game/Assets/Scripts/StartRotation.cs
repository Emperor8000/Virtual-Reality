using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RotateObject))]
public class StartRotation : MonoBehaviour
{
    RotateObject rotator = null;
    void Start()
    {
        rotator = GetComponent<RotateObject>();

        rotator.SetIsRotating(true);
    }
}
