using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        SetUpMusicSingelton();
        audioSource = GetComponent<AudioSource>();
    }

    private void SetUpMusicSingelton()
    {
        int numberOfMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if (numberOfMusicPlayers > 1)
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void MuteMusicAudio()
    {
        audioSource.mute = true;
    }

    public void UnMuteMusicAudio()
    {
        audioSource.mute = false;
    }
}
