using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIControllerGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private TextMeshProUGUI countDownText;
    [SerializeField] private GameObject panelGameOver;

    private float timeStart = 30f;
    private float currentTime;
    private int count;
    public int Count 
    {
        get => count;
        set => count = value;
    }

    private void Start()
    {
        currentTime = timeStart;
        Count = 0;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        countDownText.text = "Time left: " + currentTime.ToString("0");

        if (currentTime <= 0f)
        {
            ShowPanelGameOver(0);
        }
    }

    public void SetCountText()
    {
        countText.text = "Count: " + Count.ToString();

        if (Count >= 12)
        {
            ShowPanelGameOver(1);
        }
    }

    private void ShowPanelGameOver(int messageID)
    {
        Time.timeScale = 0f;
        panelGameOver.SetActive(true);

        switch (messageID)
        {
            case 0:
                gameOverText.text = "You run out time!";
            break;

            case 1:
                gameOverText.text = "Congratulations, you win!";
            break;
        }
    }

    #region ButtonMethods
    public void ButtonRestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        
    }

    public void ButtonBackMainMenu()
    {
        SceneManager.LoadScene(0);
    } 
    #endregion
}
