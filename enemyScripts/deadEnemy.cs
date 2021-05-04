
using UnityEngine;




public class deadEnemy : MonoBehaviour
{
    public GameObject bullet;
    

   


    private void OnTriggerEnter2D(Collider2D bullet)
    {
        GameObject.Destroy(gameObject);
        
    }       
    
}
