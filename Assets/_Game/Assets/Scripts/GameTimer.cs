using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class GameTimer : MonoBehaviour
{
    [SerializeField] [Tooltip ("Time in minutes until game over")] private float TotalTime = 15f;
    [SerializeField] private UnityEvent timeUp;
    [SerializeField] private TextMeshProUGUI textField;

    [HideInInspector] public float currentTime = 0f;
    void Start()
    {
        currentTime = TotalTime * 60;
    }

    // Update is called once per frame
    void Update()
    {
        float currentMinutes = Mathf.FloorToInt(currentTime / 60);
        float currentSeconds = Mathf.RoundToInt(currentTime % 60);
        if(currentSeconds >= 10)
        {
            textField.text = currentMinutes.ToString() + " : " + currentSeconds.ToString();
        }
        else
        {
            textField.text = currentMinutes.ToString() + " : 0" + currentSeconds.ToString();
        }
        
        currentTime -= Time.deltaTime;
        if(currentTime <= 0)
        {
            timeUp.Invoke();
            this.enabled = false;
        }
    }
}
