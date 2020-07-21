using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaultManager : MonoBehaviour
{

    public Text cellWallEquatiion; // in the first room
    public Text hallWallEquation; // in the hall

    //for easier life
    [SerializeField] string cellPassKeyOnBlue;
    [SerializeField] string cellPassKeyOnRed;

    
    string correctCellPassKey;

    enum deathlyHallows { wand, stone, cloak };


    deathlyHallows dh;
    DataKeeper dk;
    [Range(1, 3)] int deathlyHallowsColor; // each represent a color randomized for it

    //E23522   red color
    //477422   green color
    //2659B0   blue color

    //4C515A   normal color 

    // Start is called before the first frame update
    void Start()
    {
        dk = GameObject.FindGameObjectWithTag("DataKeeper").GetComponent<DataKeeper>();


        int temp;
        temp = Randomize(0, 2);

        // cell wall randomize
        if (temp == 0) // if 0 makes it red
        {
            cellWallEquatiion.text = "<color=#E23522>Y</color><color=#4C515A>= 2x + 6</color>";
            correctCellPassKey = cellPassKeyOnRed;
        }
        else //blue
        {
            cellWallEquatiion.text = "<color=#081DBA>Y</color><color=#4C515A>= 2x + 6</color>";
            correctCellPassKey = cellPassKeyOnBlue;

        }

        // randomize hall wall equation
        temp = Randomize(0, 3);

        if (temp == 0) // red
        {
            // deathly hallows the red shape
            deathlyHallowsColor = 1;
            hallWallEquation.text = "<color=#E23522>X</color><color=#4C515A>= 6y + 9</color>";
            dh = deathlyHallows.wand;

        }
        else if (temp == 1) // green
        {
            // deathly hallows green
            deathlyHallowsColor = 2;
            hallWallEquation.text = "<color=#477422>X</color><color=#4C515A>= 6y + 9</color>";
            dh = deathlyHallows.stone;
        }
        else //blue
        {
            //deathly hallows Blue
            deathlyHallowsColor = 3;
            hallWallEquation.text = "<color=#2659B0>X</color><color=#4C515A>= 6y + 9</color>";
            dh = deathlyHallows.cloak;
        }
        dh = deathlyHallows.cloak;
        dk.SetCorrectPass(correctCellPassKey , 0); // storing correct password by door ID
        dk.RiddleSetup((int) dh); //storing correct deathly hallow

    }



    int Randomize(int min, int max)
    {
        int rand = Random.Range(min, max);

        return rand;
    }

    int GetDeathlyHallow()
    {
        return deathlyHallowsColor;
    }

    string GetCellPassKey()
    {
        return correctCellPassKey;
    }

    




}
