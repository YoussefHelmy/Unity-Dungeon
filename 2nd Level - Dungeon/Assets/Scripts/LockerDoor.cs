using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoor : MonoBehaviour
{
    public GameObject DoorTrigger;
    public GameObject dependency;
    [SerializeField] [Range(0, 2)] int lockerNumber;
    DataKeeper dk;
    Animator anime;
    bool inRange;
    bool opened = false;


    void Start()
    {
        int correctLockerNumber;
        anime = GetComponent<Animator>();
        DoorTrigger.SetActive(false);
        dk = GameObject.FindGameObjectWithTag("DataKeeper").GetComponent<DataKeeper>();
        dependency.SetActive(false);
        opened = false;
        correctLockerNumber = dk.GetLockerNumber();
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player" && !opened)
        {
            DoorTrigger.SetActive(true);
            inRange = true;
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        DoorTrigger.SetActive(false);
        inRange = false;
    }


    void OpenDoor()
    {
        anime.SetBool("DoorOpen", true);
    }

    
    private void Update()
    {
        if (inRange)
        {
            if (Input.GetButtonDown("Interact"))
            {
                OpenDoor();
                opened = true;
                if (dk.GetLockerNumber() == lockerNumber)
                {
                    dependency.SetActive(true);
                }
            }
        }
    }
}