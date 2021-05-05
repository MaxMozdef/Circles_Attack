using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;


public class MainMenu : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GlobalScore()
    {
        SceneManager.LoadScene(3);
    }    

    public void FAQ()
    {
        SceneManager.LoadScene(4);
    }

    public void Exit()
    {
        Application.Quit();
        PlayGamesPlatform.Instance.SignOut();
    }
}
