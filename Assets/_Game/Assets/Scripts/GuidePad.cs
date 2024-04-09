using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuidePad : MonoBehaviour
{
    [SerializeField] private List<string> Steps = new List<string>();
    [SerializeField] private List<string> Hints = new List<string>();
    private TextMeshProUGUI GuideText = null;

    private int currentStep = 0;
    private bool hint = false;
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
            hint = false;
        }
        
        setText();
    }
    public void NextStep()
    {
        if(currentStep < Steps.Count-1)
        {
            currentStep++;
            hint = false;
        }
        
        setText();
    }

    public void toggleHint()
    {
        if (!hint)
        {
            hint = true;
        }else if (hint)
        {
            hint = false;
        }

        setText();
    }

    public void setText()
    {
        if (!hint)
        {
            GuideText.text = Steps[currentStep];
        }
        else if (hint)
        {
            GuideText.text = "Hint: " + Hints[currentStep];
        }
        
    }
}
