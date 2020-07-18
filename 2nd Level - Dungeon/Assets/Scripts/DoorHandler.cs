using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorHandler : MonoBehaviour
{
    public GameObject DoorTrigger;
    public GameObject uiCanvas;
    public GameObject dependency;
    [SerializeField] bool hasDependancy = false;
    [SerializeField] bool hasUI = false;
    [SerializeField] int doorID;
    public Text display;
    public AudioClip openSFX;
    DataKeeper dk;
    bool paused = false;
    Animator anime;
    bool inRange;
    GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        uiCanvas.SetActive(false);
        DoorTrigger.SetActive(false);
        dk = GameObject.FindGameObjectWithTag("DataKeeper").GetComponent<DataKeeper>();
        if (hasDependancy)
        {
            dependency.SetActive(false);
        }
    }

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            DoorTrigger.SetActive(true);
            inRange = true;
            Player = other.gameObject;
        }
    }


    void PausingGame(GameObject other)
    {
        if (!(paused))
        {
            PauseGame(other.gameObject);
        }
        else
        {
            UnpauseGame(other.gameObject);
        }
    }

    void PauseGame(GameObject other)
    {
        uiCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        other.transform.GetComponent<PlayerController>().enabled = false;
        other.GetComponentInChildren<MouseLooker>().enabled = false;
        paused = true;
    }

    void UnpauseGame(GameObject other)
    {
        uiCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        other.transform.GetComponent<PlayerController>().enabled = true;
        other.GetComponentInChildren<MouseLooker>().enabled = true;
        paused = false;
        
    }

    private void OnTriggerExit(Collider other)
    {
        DoorTrigger.SetActive(false);
        uiCanvas.SetActive(false);
        inRange = false;
        Player = null;
    }


    void OpenDoor()
    {
        anime.SetBool("DoorOpen", true);
        GetComponent<AudioSource>().PlayOneShot(openSFX);
    }

    void CloseDoor()
    {
        anime.SetBool("DoorOpen", false);
    }

    private void Update()
    {
        if (inRange)
        {
            if (Input.GetButtonDown("Interact"))
            {
                if ((dk.CheckedLockedWithDoorID(doorID)))
                {
                    
                    PausingGame(Player);

                }
                else
                {
                    OpenDoor();
                    UnpauseGame(Player);
                    if (hasDependancy)
                    {
                        dependency.SetActive(true);
                    }
                }
            }
        }
        if (hasUI)
        {
            display.text = dk.GetCurrentDoorPasswordWithID(doorID);
        }
    }


}
