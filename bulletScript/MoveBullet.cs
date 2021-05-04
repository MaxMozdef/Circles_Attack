using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveBullet : MonoBehaviour
{
    public float speed = 3f;
    public GameObject Bullet;
    public Vector2 movement;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Bullet.transform.position.y > 5.6f)
        {
            GameObject.Destroy(Bullet);
        }
        rb.AddForce(movement.normalized * speed, ForceMode2D.Impulse);
        
    }
    private void OnTriggerEnter2D(Collider2D boolletColl)
    {
        if (boolletColl.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
