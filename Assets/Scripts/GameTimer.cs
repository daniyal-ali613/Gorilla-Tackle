using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameTimer : MonoBehaviour
{
    Text timeText;
    int secondsLeft = 45;
    bool timeRunning = false;


    void Start()
    {
        timeText = GetComponent<Text>();
        timeText.text = secondsLeft + "";

    }

    void Update()
    {
        if (timeRunning == false && secondsLeft > 0)
        {
            StartCoroutine(RunTimer());
        }

        if (secondsLeft < 1)
        {
            FindObjectOfType<SceneLoader>().LoadGameOverEnglish();
        }
    }

    IEnumerator RunTimer()
    {
        timeRunning = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        timeText.text = secondsLeft + "";




        timeRunning = false;
    }

    public void SubtractFromTime(int sub)
    {
        secondsLeft -= sub;
    }

    public int GetTime()
    {
        return secondsLeft;
    }

}
