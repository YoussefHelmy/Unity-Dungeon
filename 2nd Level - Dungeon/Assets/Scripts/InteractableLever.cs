
using UnityEngine;

public class InteractableLever : MonoBehaviour
{
    public int lightnumber;
    public GameObject PuzzleLight;
    bool inRange = false;
    int[] SecondPuzzleSol = new int[] {1,2,3,4,1};
    static int Count = 0;
    
    
    public void Update()
    { 
       if (inRange && Input.GetKeyDown(KeyCode.E))
        {
           
            if(Count < 5){
                if (lightnumber == SecondPuzzleSol[Count])
                { 
                    Count++;
                    
                } 
                else Count = 0;

            }
            if (Count >=5)
            {
                GameObject.FindGameObjectWithTag("Master").GetComponent<DungeonMaster>().Solved(1);
            }

            if (PuzzleLight.active)

            {
                PuzzleLight.SetActive(false);
            }
            else
            {
                PuzzleLight.SetActive(true);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        
            inRange = true;
    }
    private void OnTriggerExit(Collider other)
    {

        inRange = false;
    }
    
}