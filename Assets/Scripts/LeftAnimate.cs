using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAnimate : MonoBehaviour
{
    public Sprite LeftSprite;
    public Sprite OriginalSprite;
    public GameObject Ball;
    public GameObject CaughtPlayer;
    private SpriteRenderer spriteRenderer;
    PlaySound ply;
    float Xpos = -0.9f;
    float Ypos = -0.3f;
    Score gameScore;
    Vector2 pos;
    Vector2 sca;




    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        pos = gameObject.transform.position;
        sca = gameObject.transform.localScale;
        gameScore = FindObjectOfType<Score>();
        ply = FindObjectOfType<PlaySound>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(Base());
        }

        else if (coll.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Busted());
            Destroy(coll.gameObject);

        }

    }


    public void AnimateLeftHand()
    {
        StartCoroutine(AnimateL());
    }

    IEnumerator AnimateL()
    {
           spriteRenderer.sprite = LeftSprite;
           transform.position =   new Vector2(Xpos, Ypos);
           transform.localScale = new Vector2(2.753712f, 3.939759f);

            yield return new WaitForSeconds(0.5f);

            spriteRenderer.sprite = OriginalSprite;
            transform.position = pos;
            transform.localScale = sca;

    }

    IEnumerator Base()
    {
        Ball.SetActive(true);
        gameScore.AddToScore(1);
        ply.BallGrabSound();

        yield return new WaitForSeconds(1f);

        Ball.SetActive(false);



    }

    IEnumerator Busted()
    {
        CaughtPlayer.SetActive(true);
        ply.PlayerBustedSound();

        yield return new WaitForSeconds(1f);

        CaughtPlayer.SetActive(false);




    }
}
