using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DoorLock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public bool isLocked = false;
    [SerializeField] public GameObject key = null;

 
    [HideInInspector]public GameObject givenKey = null;

     private Rigidbody _rb = null;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        if (isLocked)
        {
            //lock the door
            _rb.isKinematic = true;
        }
        else
        {
            _rb.isKinematic = false;
        }
    }

    public void unlockDoor()
    {
        //unlock the door
        
        if (true)
        {
            if (givenKey == key)
            {
                Rigidbody keyRB = givenKey.GetComponent<Rigidbody>();
                keyRB.isKinematic = true;
                Collider keyCollider = givenKey.GetComponent<Collider>();
                keyCollider.enabled = false;

                _rb.isKinematic = false;
            }
        }
    }
}
