using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(HingeJoint))]
public class TurnKey : MonoBehaviour
{
    private HingeJoint keyHinge = null;
    private Collider thisCollider = null;
    public DoorLock doorLockScript = null;

    private void Awake()
    {
        keyHinge = GetComponent<HingeJoint>();
        thisCollider = GetComponentInChildren<Collider>();
    }

    private void Update()
    {
        if(Mathf.Abs(keyHinge.angle) >= 45)
        {
            Debug.Log("invoked unlock");
            doorLockScript.unlock.Invoke();
            gameObject.SetActive(false);
        }
    }
}
