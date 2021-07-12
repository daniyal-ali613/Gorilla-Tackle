using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [Header("TimeOver Sound")]
    [SerializeField] AudioClip timeOverSound;

    [Header("Buton Sound")]
    [SerializeField] AudioClip btnSound;

    [Header("Ball Grabe Sound")]
    [SerializeField] AudioClip grabSound;

    [Header("Player Busted Sound")]
    [SerializeField] AudioClip playerBusterSound;

    [Header("New Purchase")]
    [SerializeField] AudioClip newPurchase;


    AudioSource audioSrc;

    private void Start()
    {
       // DontDestroyOnLoad(this);
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlayTimeOverSound()
    {
        audioSrc.PlayOneShot(timeOverSound);
    }

    public void ButtonSound()
    {
        audioSrc.PlayOneShot(btnSound);
    }

    public void BallGrabSound()
    {
        audioSrc.PlayOneShot(grabSound);
    }

    public void PlayerBustedSound()
    {
        audioSrc.PlayOneShot(playerBusterSound);

    }

    public void NewBallPurchase()
    {
        audioSrc.PlayOneShot(newPurchase);

    }

    public void MuteSoundAudio()
    {
        audioSrc.mute = true;
    }

    public void UnMuteSoundAudio()
    {
        audioSrc.mute = false;
    }

}
