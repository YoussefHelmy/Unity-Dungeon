using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{

    static GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void clicks(string c)
    {

        if (c == "start")
        {
            gm.StartNewGame();
        }
        else if (c == "restart")
        {
            gm.RestartLevel();
            Debug.Log("restart");

        }
        else if (c == "quit")
        {
            gm.ExitGame();
            Debug.Log("quit");

        }
        else if (c == "resume")
        {
            gm.Resume();
        }


    }



}
