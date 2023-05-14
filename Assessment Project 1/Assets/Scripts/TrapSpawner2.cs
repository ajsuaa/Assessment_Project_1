using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner2 : MonoBehaviour
{
    public GameObject trapPrefab;
    private float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        //This line of code was obtained via an tutorial
        StartCoroutine(SpawnTrap());
    }
    
    IEnumerator SpawnTrap()
    {
        //Delays the traps spawnrate
        yield return new WaitForSeconds(5f);

        //Restricts how far away the trap can spawn from the baseplate
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        //Allows new-spawned trap to spawn at a random position on the baseplate
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        Instantiate(trapPrefab, randomPos, Quaternion.identity);

        // Restart the coroutine to spawn the next trap
        //This line of code was obtained via an tutorial
        StartCoroutine(SpawnTrap());

    }

}
