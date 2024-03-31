using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendKey : MonoBehaviour
{
    [SerializeField] private DoorLock lockScript = null;

    private void Start()
    {
        lockScript = GetComponentInParent<DoorLock>();
    }
    private void OnTriggerEnter(Collider other)
    {
        lockScript.givenKey = other.gameObject;
    }
}
