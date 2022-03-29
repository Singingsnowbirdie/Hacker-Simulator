using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameController game;
    bool isTimer = true;
    float timeLimit = 60f;

    void Start()
    {
        timerText.text = timeLimit.ToString();
    }

    void Update()
    {
        if (isTimer)
        {
            timeLimit -= Time.deltaTime;
            timerText.text = $"{timeLimit:f2}";
            if (timeLimit <= 0)
            {
                game.Defeat();
            }
        }
    }
}
