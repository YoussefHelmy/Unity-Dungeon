using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonMaster : MonoBehaviour
{
    public Material EyesOff;
    public Material EyesOn;
    public GameObject Portal;
    public GameObject[] deathEyes;
    bool[] puzzles = { false, false, false };

    bool opened = false;
    

    public void Solved(int index)
    {
        puzzles[index] = true;

        deathEyes[index].GetComponent<MeshRenderer>().material = EyesOn;

        
    }

    void Start()
    {
        deathEyes[0].GetComponent<MeshRenderer>().material = EyesOff;
        deathEyes[1].GetComponent<MeshRenderer>().material = EyesOff;
        deathEyes[2].GetComponent<MeshRenderer>().material = EyesOff;
        Portal.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        if (puzzles[0] && puzzles[1] && puzzles[2] && !opened)
        {
            Portal.SetActive(true);
            opened = true;
        }
    }
}
