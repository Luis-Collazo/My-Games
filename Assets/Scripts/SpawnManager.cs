using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = -36;
    private float spawnPosZ = 15;
    private float startDelay = 2;
    private float spawnInterval =  1.5f;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
