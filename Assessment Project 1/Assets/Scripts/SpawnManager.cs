using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject enemyPrefab;
    //The range of where the enemies can spawn
    private float spawnRange = 9;
    //Counts how many enemies are currently active
    public int enemyCount;
    //Indicates the 1st wave
    public int waveNumber = 1;
  

    // Start is called before the first frame update
    void Start()
    {
        //The wave number tells how many enemies should spawn
        SpawnEnemyWave(waveNumber);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {

        //Make specific amount of balls for each wave
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            //New-spawned enemies spawn in a new position
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Counts how many enemies are in current wave
        enemyCount = FindObjectsOfType<Enemy>().Length;

        //When there are currently 0 enemies, generate a new wave of enemies
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }

    //Custom Function = Tidy Code
    private Vector3 GenerateSpawnPosition()
    {
        //Allows new enemies to spawn in a random position
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }

}

