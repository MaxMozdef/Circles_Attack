using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class TotScore : MonoBehaviour
{
    public Text totalScoreAllString;
    public int totalScoreAllInt;
    public int gameScore =0;    
    public string leaderBoard = "CgkIoMmeuboKEAIQAA";    

    void Start()
    {
        totalScoreAllInt = PlayerPrefs.GetInt("totalGameScore");
        gameScore = PlayerPrefs.GetInt("gameScore");

        
        totalScoreAllInt += gameScore;

        PlayerPrefs.SetInt("totalGameScore", totalScoreAllInt);
        gameScore = 0;
        PlayerPrefs.SetInt("gameScore", gameScore);        
    }


    
    void Update()
    {
        totalScoreAllString.text = "MY TOTAL E-SCORE " + totalScoreAllInt;        
    }   



    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ShowLeaderBoard()
    {
        //Social.ShowLeaderboardUI();
        PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIoMmeuboKEAIQAA");

    }
}
