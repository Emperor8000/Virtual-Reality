using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnDistanceGrab : MonoBehaviour
{
    [SerializeField] private SetInteractionLayer setRightHand = null;
    [SerializeField] private SetInteractionLayer setLeftHand = null;
    private void Awake()
    {
        setLeftHand.ToggleTargetLayer(true);
        setRightHand.ToggleTargetLayer(true);
    }
}
