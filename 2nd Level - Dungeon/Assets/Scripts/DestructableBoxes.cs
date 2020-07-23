using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableBoxes : MonoBehaviour
{
    public int boxNumber;
    public GameObject intactBox;
    public GameObject shatteredBox;
    int []solution = {1 , 2  ,3, 4, 5};
    static int Count = 0;
    bool hit = false;
    MysticCaveMaster mc;
    static float time = 0.0f;
   public static float interpolationPeriod = 5;
    bool wrongAnser = false;
    public GameObject Statue;

    void Start()
    {
        mc = GameObject.FindGameObjectWithTag("GameController").GetComponent<MysticCaveMaster>();
    }


    public void Update()
    {
        if (hit)
        {
            intactBox.SetActive(false);
            Instantiate(shatteredBox, transform.position, transform.rotation);
            GetComponent<BoxCollider>().enabled = false;
            hit = false;

            if (Count < 5)
            {
                if (boxNumber == solution[Count])
                {   
                    Count++;
                    
                    Debug.Log("Correct , box hit is + " + boxNumber);
                }
                else if (boxNumber != solution[Count]) 
                {
                    Count = 0;
                    wrongAnser = true;
                    time = 0.0f;
                    Debug.Log("wrong , box hit is + " + boxNumber);
                }

            }
            if (Count >= 5)
            {
                mc.Solved(0);
                Destroy(Statue);

            }

        }

        time += Time.deltaTime;

        if (time >= interpolationPeriod && wrongAnser == true)
        {
            time = 0.0f;
            mc.ResetBoxes();
            wrongAnser = false;

        }

    }

    public void ResetBox()
    {
        intactBox.SetActive(true);
        GetComponent<BoxCollider>().enabled = true;

    }


    public void Damage()
    {
        hit = true;
    }




}
