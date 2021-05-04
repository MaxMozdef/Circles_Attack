using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMOS : MonoBehaviour
{
    [SerializeField]private GameObject bonusMOS;
    
    void Start()
    {
        StartCoroutine(spawnBonusMOS());
    }

    
    IEnumerator spawnBonusMOS()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(222f, 306f));            
            spawnBonusMOScore();
        }
        
    }
    void spawnBonusMOScore()
    {
        
            Vector3 randomPositionMOS = new Vector3(Random.Range(-2.1f, 2.1f), 6.6f, 0);
            Instantiate(bonusMOS, randomPositionMOS, Quaternion.identity);
               
    }    
}
