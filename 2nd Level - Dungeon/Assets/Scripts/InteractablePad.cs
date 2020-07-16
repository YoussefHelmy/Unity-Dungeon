using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePad : MonoBehaviour
{
    public int Padnumber;
    public static int Count = 0;
    public int[] ThirdPuzzleSol = new int[] { 1, 2, 3, 4, 1 };



    private void OnTriggerEnter(Collider other)
    {
        if (Count <= 5)
        {
            if (Padnumber == ThirdPuzzleSol[Count])
            {
                Count++;
                Debug.Log(Count);
            }
            else { Count = 0;  } 

        }
    
    }


}
