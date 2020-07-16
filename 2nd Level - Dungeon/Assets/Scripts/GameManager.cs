using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool hasGameLostUI = false;

    public GameObject GameLostUI;

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Resume()
    {

    }

    public void GameLost()
    {
        if (hasGameLostUI)
        {
            GameLostUI.SetActive(true);
        }
        Invoke("RestartLevel", 2);
    }

}
