using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Break : MonoBehaviour
{
    [SerializeField] private GameObject breaker = null;
    [SerializeField] private GameObject brokenObject = null;
    [SerializeField] private Transform brokenObjectTransform = null;

    [SerializeField] private UnityEvent broken;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == breaker || other.transform.parent.gameObject == breaker)
        {
            broken.Invoke();
        }
    }

    public void createBrokenObject()
    {
        Instantiate(brokenObject, brokenObjectTransform.position, brokenObjectTransform.rotation);
    }
}
