using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool pause = false;
    [SerializeField] bool isLevel;
    public GameObject pauseMenuCanvas;
    public bool hasGameLostUI = false;
    bool dead = false;

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
        pause = false;
        pauseMenuCanvas.SetActive(false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = true;
        Camera.main.GetComponent<MouseLooker>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        pause = true;
        pauseMenuCanvas.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
        Camera.main.GetComponent<MouseLooker>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    void Start()
    {
        if (isLevel)
        {
            pauseMenuCanvas.SetActive(false);
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
        pause = false;

        

    }
    public void GameLost()
    {
        if (hasGameLostUI && isLevel)
        {
            GameLostUI.SetActive(true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
            Camera.main.GetComponent<MouseLooker>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            dead = true;

        }
        else
        {
            Invoke("RestartLevel", 2);
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && isLevel && !dead)
        {
            if (pause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

}
