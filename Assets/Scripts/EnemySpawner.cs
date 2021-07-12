using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    float Xpos =  6.31f;
    float Ypos = -3.6f;
    bool spawn = true;

    public GameObject enemyPrefab;

    void Start()
    {
        StartCoroutine(EnSpawner());
    }


    IEnumerator EnSpawner()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));

            Instantiate(enemyPrefab,new Vector2(Xpos, Ypos), transform.rotation);

        }
    }

    
}
