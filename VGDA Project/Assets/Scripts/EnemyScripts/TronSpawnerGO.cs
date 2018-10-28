using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TronSpawnerGO : MonoBehaviour {

    public Vector2 min;
    public Vector2 max;
    public GameObject EnemyGO; //enemy prefab

    float maxSpawnRateInSeconds = 8f;

    // Use this for initialization
    void Start()
    {

        Invoke("SpawnEnemy", maxSpawnRateInSeconds);
        // Increase spawn Rate every 30 seconds
        InvokeRepeating("IncreaseSpawnRate", 0f, 90f);
    }

    // Update is called once per frame
    void Update()
    {



    }
    // Function to spawn enemy
    void SpawnEnemy()
    {

        //instantiate an enemy
        GameObject anEnemy = (GameObject)Instantiate(EnemyGO);
        anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);

        //Schedule when spawn next enemy
        ScheduleNextEnemySpawn();
    }
    void ScheduleNextEnemySpawn()
    {
        float spawnInNSeconds;
        if (maxSpawnRateInSeconds > 1f)
        {
            spawnInNSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spawnInNSeconds = 1f;
        Invoke("SpawnEnemy", spawnInNSeconds);
    }
    //Function tp increase the difficulty of the game
    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;

        if (maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");
    }
}
