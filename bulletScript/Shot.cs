using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    public Camera mainCamera;



    void Awake()
    {
        Input.multiTouchEnabled = false;
    }
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet,mainCamera.ScreenToWorldPoint(Input.mousePosition)+Vector3.forward,Quaternion.identity);            
        }        
    }
}
