using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Challenge : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI racingCirclesText;
    [SerializeField] TextMeshProUGUI lastCircleTimeText;
    [SerializeField] TextMeshProUGUI previousCircleTimeText;

    float totalTime;
    float lastCircleTime;
    float previousCircleTime;
    int circles;
    bool isStarted;

    void Start()
    {
        Debug.Log(Mathf.Round(7.7f));
        Debug.Log(Mathf.Round(1.4f));
        Debug.Log(Mathf.Round(5.5f));
        Debug.Log(Mathf.Round(6.5f));
        Debug.Log(Mathf.Round(-0.5f));
    }

    public void OnPressed()
    {
        if (!isStarted)
        {
            StartCoroutine(Timer());
            isStarted = true;
        }
        else
        {
            StopAllCoroutines();
            circles++;
            racingCirclesText.text = "Пройдено кругов: " + circles.ToString();
            previousCircleTimeText.text = "Предыдущий круг пройден за " + previousCircleTime.ToString() + " секунд";
            lastCircleTimeText.text = "Последний круг пройден за " + lastCircleTime.ToString() + " секунд";
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        if (lastCircleTime != 0)
        {
            previousCircleTime = lastCircleTime;
            lastCircleTime = 0;
        }
        while (true)
        {
            yield return new WaitForSeconds(1);
            lastCircleTime++;
            totalTime++;
            timerText.text = "С начала гонки прошло: " + totalTime.ToString() + " секунд";
        }

    }

}
