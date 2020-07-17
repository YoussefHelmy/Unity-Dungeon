using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePad : MonoBehaviour
{
    public int Padnumber;
    static int Count = 0;
    public int[] ThirdPuzzleSol = new int[] { 1, 2, 3, 4, 1 };
    bool restrict = true;



    private void OnTriggerEnter(Collider other)
    {
         
        if (Count < 5  && restrict)
        {
            if (Padnumber == ThirdPuzzleSol[Count])
            {
                Count++;
                Debug.Log(Count);

            }
            else { Count = 0;
                Debug.Log("fail");
            }
        }
        if (Count >= 5 && restrict)
        {
            GameObject.FindGameObjectWithTag("Master").GetComponent<DungeonMaster>().Solved(2);
            Debug.Log("solved");
        }

        restrict = false;
    }

    private void OnTriggerExit(Collider other)
    {
        restrict = true;
    }




}
