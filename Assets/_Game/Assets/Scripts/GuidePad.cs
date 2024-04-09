using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuidePad : MonoBehaviour
{
    [SerializeField] private List<string> Steps = new List<string>();
    private TextMeshProUGUI GuideText = null;

    private int currentStep = 0;
    void Start()
    {
        if (!GuideText)
        {
            GuideText = GetComponent<TextMeshProUGUI>();
        }
    }
    public void LastStep()
    {
        if(currentStep > 0)
        {
            currentStep--;
        }
        
        setText();
    }
    public void NextStep()
    {
        if(currentStep < Steps.Count-1)
        {
            currentStep++;
        }
        
        setText();
    }

    public void setText()
    {
        GuideText.text = Steps[currentStep];
    }
}
