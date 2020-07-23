using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    GameManager gm;
    void Start()
    {

        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
    }


    private void OnTriggerEnter(Collider Player)
    {

        gm.NextLevel();

    }




}
