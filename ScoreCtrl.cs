using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCtrl : MonoBehaviour
{
    public Text txtPoint;
    public int gameScore;
    public float timeBonus;
    public TotScore scriptTotScore;
    
    

    void Start()
    {
        StartCoroutine(score());

    }


    void Update()
    {
        txtPoint.text = "E - SCORES: " + gameScore;
        timeBonus = Time.time / 100f;
    }


    IEnumerator score()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5.1f - timeBonus, 7.7f - timeBonus));
            gameScore++;


            PlayerPrefs.SetInt("gameScore", gameScore);
            
        }
        
    }


}
