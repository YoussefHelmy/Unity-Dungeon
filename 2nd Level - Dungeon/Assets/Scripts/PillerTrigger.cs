using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerTrigger : MonoBehaviour
{
    public GameObject orb;
    public int orbNumber;
    int[] solution = { 1, 2, 3, 4, 5 };
    static int Count = 0;
    MysticCaveMaster mc;
    static float time = 0.0f;
    public static float interpolationPeriod = 5;
    bool wrongAnser = false;
    bool inRange = false;

    // Start is called before the first frame update
    void Start()
    {
        mc = GameObject.FindGameObjectWithTag("GameController").GetComponent<MysticCaveMaster>();
        orb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetButtonDown("Interact"))
        {
            

            if (Count < 5)
            {
                if (orbNumber == solution[Count])
                {
                    Count++;
                    orb.SetActive(true);
                    Debug.Log("Correct , orb triggered is + " + orbNumber);
                }
                else if (orbNumber != solution[Count])
                {
                    Count = 0;
                    wrongAnser = true;
                    time = 0.0f;
                    Debug.Log("wrong , orb triggered is + " + orbNumber);
                }

            }
            if (Count >= 5)
            {
                mc.Solved(1);
                Debug.Log("solved");
            }

        }

        time += Time.deltaTime;

        if (time >= interpolationPeriod && wrongAnser == true)
        {
            time = 0.0f;
            mc.ResetOrbs();
            wrongAnser = false;

        }
    }

    public void ResetOrb()
    {
        orb.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
            inRange = false;
    }

}
