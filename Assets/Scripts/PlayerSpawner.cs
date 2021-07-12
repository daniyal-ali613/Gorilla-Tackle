using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    float Xpos = -7.448f;
    float Ypos = -2.68f;
    public GameObject playerPrefab;
    bool spawn = true;

    void Start()
    {
        StartCoroutine(Spawner());
    }


    IEnumerator Spawner()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));

            Instantiate(playerPrefab, new Vector2(Xpos,Ypos), playerPrefab.transform.rotation);
        }
    }

    
}
