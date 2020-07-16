using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    Animator anime;
    public bool correct = false;
    bool inRange = false;

    private void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
    }

    private void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            if (Input.GetButtonDown("Action"))
            {
                anime.SetBool("Open", true);
                Debug.Log("open");
                if (!correct)
                {
                    GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().GameLost();
                }
                else
                {
                    GameObject.FindGameObjectWithTag("Master").GetComponent<DungeonMaster>().Solved(0);
                }
            }
        }

    }
}
