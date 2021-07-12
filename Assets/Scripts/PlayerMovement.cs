using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player Collider")
        {
            Destroy(gameObject);
        }
    }

    
}
