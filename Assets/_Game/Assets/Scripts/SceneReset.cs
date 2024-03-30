using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneReset : MonoBehaviour
{
    
    public void sceneReset()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().name);
    }
}
