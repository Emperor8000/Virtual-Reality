using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEnabled : MonoBehaviour
{
    public void toggleEnabled() 
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
