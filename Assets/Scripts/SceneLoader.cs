using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    PlaySound playSound;
    Score gameScore;


    void Start()
    {
        playSound = FindObjectOfType<PlaySound>();
        gameScore = FindObjectOfType<Score>();

    }

    public void LoadStartMenuEnglish()
    {
        SceneManager.LoadScene(0);
        playSound.ButtonSound();
    }

    public void LoadStartMenuRussian()
    {
        SceneManager.LoadScene(1);
        playSound.ButtonSound();

    }

    public void LoadShoptMenuEnglish()
    {
        SceneManager.LoadScene(2);
        playSound.ButtonSound();

    }

    public void LoadShopMenuRussian()
    {
        SceneManager.LoadScene(3);
        playSound.ButtonSound();
    }

    public void LoadGamePlay()
    {
        SceneManager.LoadScene(4);
        playSound.ButtonSound();
      //  gameScore.ResetGame();
    }


    public void LoadGameOverEnglish()
    {
        StartCoroutine(WaitAndLoadEnglish());
    }

    public void LoadGameOverRussian()
    {
        StartCoroutine(WaitAndLoadRussian());
    }

    IEnumerator WaitAndLoadEnglish()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(5);
        playSound.PlayTimeOverSound();


    }

    IEnumerator WaitAndLoadRussian()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(6);
        playSound.PlayTimeOverSound();


    }




}
