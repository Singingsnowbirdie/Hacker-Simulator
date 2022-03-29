using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StepsCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] GameController game;
    int count = 20;

    void Start()
    {
        counterText.text = count.ToString();
    }

    public void ChangeCounter()
    {
        count--;
        counterText.text = count.ToString();
        if (count <= 0)
        {
            game.Defeat();
        }

    }

}
