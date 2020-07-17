using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataKeeper : MonoBehaviour
{
    static string firstDoorCorrectPassword;
    static string firstDoorPassword = "0000";
    static bool firstDoorLocked = true;
    static int firstIndex = 0;
    static int correctLockerNumber;
    static string secondDoorCorrectPassword;
    static string secondDoorPassword = "0000000000000000000000000";
    static bool secondDoorLocked = true;
    static int secondIndex = 0;

    public RIDDELSCRIPT rs;

    void Start()
    {
        firstDoorPassword = "0000";
        firstDoorLocked = true;
        firstIndex = 0;
        secondDoorPassword = "0000000000000000000000000";
        secondDoorLocked = true;
        secondIndex = 0;
    }

    public string GetCurrentDoorPasswordWithID(int doorID)
    {
        string password = null; // to put the selected password in
        switch (doorID)
        {
            case 0:
                password = firstDoorPassword;
                break;
            case 1:
                password = secondDoorPassword;
                break;
        }
        return password;

    }

    public void RiddleSetup(int LN)
    {
        correctLockerNumber = LN;

        rs.lockernum(correctLockerNumber);
    }

    public int GetLockerNumber()
    {
        return correctLockerNumber;
    }

    public void SetCorrectPass(string pass, int doorID)
    {
        if (doorID == 0)
        {
            firstDoorCorrectPassword = pass;
        }
        else
        {
            secondDoorCorrectPassword = pass;
            Debug.Log(secondDoorCorrectPassword);
        }
    }
   
    public void AddCharacter (char c ,int doorID )
    {
        if (doorID == 0)
        {
            firstDoorPassword = firstDoorPassword.ReplaceCharToString(firstIndex, c);
            firstIndex++;
            Debug.Log( c);
        }
        else 
        {
           secondDoorPassword = secondDoorPassword.ReplaceCharToString(secondIndex, c);
            secondIndex++;
        }

    }
    
    public void RemoveLastCharacter(int doorID)
    {
        if (secondIndex != 0)
        {
            secondIndex--;
            secondDoorPassword = secondDoorPassword.ReplaceCharToString(secondIndex, '0');

        }
    }

    public void ComparePass (int doorID)
    {
        if (doorID == 0)
        {
            
            if (firstDoorPassword == firstDoorCorrectPassword)
            {
                firstDoorLocked = false;
            }
            else
            {
                firstDoorLocked = true;
            }
        }
        else
        {
            secondDoorPassword = secondDoorPassword.Replace("0", string.Empty);

            if (secondDoorPassword == secondDoorCorrectPassword)
            {
                secondDoorLocked = false;
            }
            else
            {
                secondDoorLocked = true;
            }
            Debug.Log(secondDoorLocked);
        }
    }

    public void ClearPass(int doorID)
    {
        if (doorID == 0)
        {
            firstDoorPassword = "0000";
            firstIndex = 0;
            Debug.Log("clear");
        }
        else
        {
            secondDoorPassword = "000000000000000000000000";
            secondIndex = 0;
        }
    }

    public bool CheckedLockedWithDoorID(int doorID)
    {
        bool locked;

        if (doorID == 0)
        {
            locked = firstDoorLocked;
        }
        else
        {
            locked = secondDoorLocked;
        }

        return locked;
    }

}
