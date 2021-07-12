using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;

    void Start()
    {
        SetUpSingelton();

    }

    private void SetUpSingelton()
    {
        int numberOfGameSessions = FindObjectsOfType<Score>().Length;
        if (numberOfGameSessions > 1)
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddToScore(int add)
    {
        score += add;
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }


}
