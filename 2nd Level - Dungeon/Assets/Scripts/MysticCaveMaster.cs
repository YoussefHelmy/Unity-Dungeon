using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysticCaveMaster : MonoBehaviour
{
    public GameObject[] Pillers;

    public GameObject []boxes;
    bool[] puzzles = { false, false };
    bool finished = false;
    public GameObject portal;

    // Start is called before the first frame update
    void Start()
    {
        boxes = GameObject.FindGameObjectsWithTag("Box");
        Pillers = GameObject.FindGameObjectsWithTag("Piller");

        portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished && puzzles[0] && puzzles[1])
        {
            portal.SetActive(true);
            finished = true;
        }
    }


    public void ResetBoxes()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[i].GetComponent<DestructableBoxes>().ResetBox();
        }
    }

    public void ResetOrbs()
    {
        for (int i = 0; i < Pillers.Length; i++)
        {
            Pillers[i].GetComponent<PillerTrigger>().ResetOrb();
        }
    }


    public void Solved(int index)
    {
        puzzles[index] = true;

    }


}
