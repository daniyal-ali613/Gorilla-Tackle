using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 5f;


    void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy Collider")
        {
            Destroy(gameObject);
        }
    }


}
