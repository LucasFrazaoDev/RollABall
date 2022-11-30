using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIControllerMenu : MonoBehaviour
{
    public void ButtonStartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale= 1.0f;
    }

    public void ButtonQuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
