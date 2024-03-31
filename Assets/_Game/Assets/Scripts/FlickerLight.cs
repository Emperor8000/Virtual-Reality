using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class FlickerLight : MonoBehaviour
{
    private Light currentLight = null;
    [SerializeField] public float MaxIntensity = 5;
    [SerializeField] public float MinIntensity = 1;
    [SerializeField][Tooltip ("the max change in intensity from frame to frame")] public float MaxVariance = 0.2f;

    private float currentIntensity = 0;

    private void Awake()
    {
        currentLight = GetComponent<Light>();
        currentIntensity = Random.Range(MinIntensity, MaxIntensity);
    }

    public void Update()
    {
        if (currentIntensity < MaxIntensity && currentIntensity > MinIntensity)
        {
            currentIntensity += Random.Range(-.2f, 0.2f);
        }else if(currentIntensity >= MaxIntensity)
        {
            currentIntensity -= 0.2f;
        }else if(currentIntensity <= MinIntensity)
        {
            currentIntensity += 0.2f;
        }
        currentLight.intensity = currentIntensity;
    }
}
