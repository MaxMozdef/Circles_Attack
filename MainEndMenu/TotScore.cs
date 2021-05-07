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
    public const string leaderBoard = "CgkIoMmeuboKEAIQAA";    

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
    
    public void LeaderBoardScore()
    {
        if (PlayerPrefs.GetInt("totalGameScore", 0) == 0)
        {
            return;
        }
        Social.ReportScore(PlayerPrefs.GetInt("totalGameScore", 1),leaderBoard, (bool success) =>
        {
            if (success)
            {
                print("zaebis");
            }
        });
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void OpenLeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }
}
