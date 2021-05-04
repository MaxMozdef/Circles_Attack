using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    public float healthPoint;
    public respEnemy respTimeEnemy;
    public ScoreCtrl scorePoints;
        
    void Start()
    {
        healthPoint = 1f;
    }

    
    void Update()
    {
        bar.fillAmount = healthPoint;
        if (healthPoint > 1f)
        {
            healthPoint = 1f;
        }
        if (healthPoint <= 0f)
        {
            SceneManager.LoadScene(2);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D HBColl)
    {
        if (HBColl.gameObject.name == "EnemyBig(Clone)")
        {
            healthPoint -= 0.39f;
            Handheld.Vibrate();
        }

        if (HBColl.gameObject.name == "EnemyMedium(Clone)")
        {
           healthPoint -= 0.22f;
            Handheld.Vibrate();
        }

        if (HBColl.gameObject.name == "EnemySmall(Clone)")
        {
            healthPoint -= 0.09f;
            Handheld.Vibrate();
        }
        
        if (HBColl.gameObject.name == "BonusHP(Clone)")
        {
            healthPoint += 0.13f;
        }

        if (HBColl.gameObject.name == "BonusTime(Clone)")
        {
            respTimeEnemy.spawnRate += 0.2f;
        }

        if (HBColl.gameObject.name == "MultiplicationOfPoints(Clone)")
        {
            scorePoints.gameScore *= 2;
        }
    }
}
