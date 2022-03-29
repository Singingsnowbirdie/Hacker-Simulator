using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] GameObject introPanel;
    [SerializeField] GameObject timeModeIntroText;
    [SerializeField] GameObject stepsModeIntroText;
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;
    [SerializeField] GameObject pausePanel;

    [Header("Mods")]
    [SerializeField] GameObject timer;
    [SerializeField] GameObject stepsCounter;

    [Header("Audio")]
    [SerializeField] AudioSource backgroundMusic;
    [SerializeField] AudioSource disturbingMusic;

    [Header("Rings")]
    [SerializeField] List<Ring> rings;


    void Start()
    {
        if (GameModeController.isTimerMode)
        {
            timeModeIntroText.SetActive(true);
        }
        else
        {
            stepsModeIntroText.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausePanel.activeSelf)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void StartGame()
    {
        introPanel.SetActive(false);
        mainPanel.SetActive(true);
        backgroundMusic.Stop();
        disturbingMusic.Play();
        SetMode();
    }

    void SetMode()
    {
        if (GameModeController.isTimerMode)
        {
            timer.SetActive(true);
        }
        else
        {
            stepsCounter.SetActive(true);
        }
    }

    bool CheckRingsPos()
    {
        bool isCompleted = true;
        for (int i = 1; i < rings.Count; i++)
        {
            if (rings[i].Pos != rings[i - 1].Pos)
            {
                isCompleted = false;
                break;
            }
        }
        return isCompleted;
    }

    public void CheckProgress()
    {
        if (CheckRingsPos())
        {
            Win();
        }
    }

    void Win()
    {
        mainPanel.SetActive(false);
        winPanel.SetActive(true);
        disturbingMusic.Stop();
        backgroundMusic.Play();
    }

    public void Defeat()
    {
        mainPanel.SetActive(false);
        losePanel.SetActive(true);
        disturbingMusic.Stop();
        backgroundMusic.Play();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
}
