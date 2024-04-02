using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOnDistanceGrab : MonoBehaviour
{
    [SerializeField] private UnityEvent onStartup;
    [SerializeField] private UnityEvent onAwake;
    private void Start()
    {
        onStartup.Invoke();
    }
    private void Awake()
    {
        onAwake.Invoke();
    }
}
