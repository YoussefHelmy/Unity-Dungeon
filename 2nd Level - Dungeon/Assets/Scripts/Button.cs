using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    static DataKeeper dk;
    [SerializeField] int ID;

    private void Start()
    {
        dk = GameObject.FindGameObjectWithTag("DataKeeper").GetComponent<DataKeeper>();

    }


    public void Clicks (string input)
    {

        if (input == "Clear")
        {
            dk.ClearPass(ID);
        }

        else if (input == "Submit")
        {
            dk.ComparePass(ID);
        }
        else if (input == "Back")
        {
            dk.RemoveLastCharacter(ID);
        }
        else
        {
            dk.AddCharacter(input[0], ID);
        }


    }




}
