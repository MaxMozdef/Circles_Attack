using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonusTime : MonoBehaviour
{
    public GameObject bonusTime;
    float spawnRate;
    float nextSpawn;
    public respEnemy respTimeEnemy;

    private void Start()
    {
        nextSpawn = Random.Range(11f, 24f);
    }
    void FixedUpdate()
    {

        if (Time.time > nextSpawn)
        {
            spawnRate = Random.Range(15f, 30f);
            nextSpawn = Time.time + spawnRate;
            RandomSpawnBonusTime();
        }
    }

    void RandomSpawnBonusTime()
    {
        
        if (respTimeEnemy.spawnRate < 0.6f)
        {
            Vector3 randomPositionBonusTime = new Vector3(Random.Range(-2.1f, 2.1f), 5.6f, 0);
            Instantiate(bonusTime, randomPositionBonusTime, Quaternion.identity);
        }
        
    }
}
