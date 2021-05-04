using UnityEngine;

public class spaunBonusHP : MonoBehaviour
{
    public GameObject bonusHP;
    float spawnRate;
    float nextSpawn;
    public HealthBar healthBar;   

    
    private void Start()
    {
        nextSpawn = Random.Range(19f, 25f);
    }
    void FixedUpdate()
    {
        
        if (Time.time > nextSpawn)
        {
            spawnRate = Random.Range(30f, 48f);
            nextSpawn = Time.time + spawnRate;
            RandomSpawnBonusHP();

        }
    }

    void RandomSpawnBonusHP()
    {        
        if (healthBar.healthPoint < 0.6f)
        {
            Vector3 randomPositionBonusHP = new Vector3(Random.Range(-2.2f, 2.2f), 5.6f, 0);
            Instantiate(bonusHP, randomPositionBonusHP, Quaternion.identity);
        }
    }

}
