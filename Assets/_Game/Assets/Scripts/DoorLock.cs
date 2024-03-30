using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public bool isLocked = false;
    void Start()
    {
        if (isLocked)
        {
            //lock the door
        }
    }

    public void unlockDoor()
    {
        //unlock the door
    }
}
