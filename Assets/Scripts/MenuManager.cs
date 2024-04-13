using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button options;
    [SerializeField] private Button exitOptions;

    public void StartBtn()
    {
        SceneManager.LoadScene("Loading");
    }

    public void OptionBtn()
    {
        exitOptions.Select();
    }

    public void ExitOptionBtn()
    {
        options.Select();
    }
}
