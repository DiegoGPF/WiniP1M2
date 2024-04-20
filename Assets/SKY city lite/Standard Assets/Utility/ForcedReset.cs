using System;
using UnityEngine;
using UnityEngine.UI; // Asegúrate de incluir este using
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(UnityEngine.UI.Image))] // Especifica el namespace completo
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}