using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deathBonusHP : MonoBehaviour
{
    public GameObject bullet; 
    
        
    private void OnTriggerEnter2D(Collider2D bullet)
    {
        GameObject.Destroy(gameObject);
        
    }
}
