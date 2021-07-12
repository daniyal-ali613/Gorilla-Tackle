using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;
    Score gameSession;

    void Start()
    {
        scoreText = GetComponent<Text>();
        gameSession = FindObjectOfType<Score>();
    }

    void Update()
    {
        scoreText.text = gameSession.GetScore().ToString();
    }


}
