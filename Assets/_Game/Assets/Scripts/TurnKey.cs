using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class TurnKey : MonoBehaviour
{
    private HingeJoint keyHinge = null;
    public DoorLock doorLock = null;

    private void Awake()
    {
        keyHinge = GetComponent<HingeJoint>();
    }

    private void Update()
    {
        if(keyHinge.angle == -90)
        {
            doorLock.unlock.Invoke();
        }
    }
}
