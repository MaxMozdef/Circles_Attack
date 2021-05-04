using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respEnemy : MonoBehaviour
{
    public GameObject[] arrayEnemy;
    int randomZoneOfSpawn;
    public float spawnRate = 2.7f;
    float nextSpawn = 0f;
   
        
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawnRate -= 0.016f;
            if (spawnRate < 0.2)
            {
                spawnRate = 0.3f;
            }
        }
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandomSpawnEnemy();            
        }        
        randomZoneOfSpawn = Random.Range(0, arrayEnemy.Length);        
    }      

    void RandomSpawnEnemy()
    {        
        Vector3 randomPositionEnemy = new Vector3(Random.Range(-2.2f, 2.2f), 6f, 0);
        Instantiate(arrayEnemy[randomZoneOfSpawn], randomPositionEnemy, Quaternion.identity);       
    }    
}
