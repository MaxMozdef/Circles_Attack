using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = -31f;
    public GameObject Enemy;
    public Vector2 movement;
    private Rigidbody2D rb;

    
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
          

    private void FixedUpdate()
    {       
        rb.AddForce(movement.normalized * speed, ForceMode2D.Force);                   
    }
}
