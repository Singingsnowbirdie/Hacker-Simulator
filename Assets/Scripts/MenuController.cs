using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] int sceneID;

    public void OnStartPress(bool isTimer)
    {
        GameModeController.isTimerMode = isTimer;
        SceneManager.LoadScene(1);
    }

    public void OnExitPress()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
