using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class EnterToGS : MonoBehaviour
{
    public static PlayGamesPlatform platform;
    void Awake()
    {        


        if(platform == null)
        {

            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;
            platform = PlayGamesPlatform.Activate();
        }

        Social.Active.localUser.Authenticate(succsess =>
        {
            if (succsess)
            {
                Debug.Log("Log is succsessfully");
            }
            else
            {
                Debug.Log("Fail!fsdfsdfsiat!!!");
            }
        });
    }   


   
}
