using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class GameButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] TextMeshProUGUI hintText;
    [SerializeField] GameController game;
    [SerializeField] StepsCounter counter;
    [SerializeField] string hintString;
    [SerializeField] List<int> values;
    [SerializeField] List<Ring> rings;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hintText.text = hintString;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hintText.text = "";
    }

    public void OnPressed()
    {
        if (!GameModeController.isTimerMode)
        {
            counter.ChangeCounter();
        }
        for (int i = 0; i < rings.Count; i++)
        {
            rings[i].SetPos(values[i]);
        }
        game.CheckProgress();
    }
}

