using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Threading;

public class UIControllerGame : MonoBehaviour
{
    private int count;

    [SerializeField] TextMeshProUGUI countText;
    [SerializeField] TextMeshProUGUI countDownText;

    private void Start()
    {
        count = 0;
    }

    public void ButtonRestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonBackMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
