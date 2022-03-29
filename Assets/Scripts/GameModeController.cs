using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeController : MonoBehaviour
{
    public static GameModeController instance = null;

    public static bool isTimerMode;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
