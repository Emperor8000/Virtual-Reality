using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendKey : MonoBehaviour
{
    [SerializeField] private DoorLock lockScript = null;

    private void Start()
    {
        if (!lockScript)
        {
            lockScript = GetComponentInParent<DoorLock>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        lockScript.currentKeys.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        lockScript.currentKeys.Remove(other.gameObject);
    }
}
