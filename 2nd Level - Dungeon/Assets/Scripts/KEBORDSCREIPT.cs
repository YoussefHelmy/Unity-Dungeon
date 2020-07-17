using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class KEBORDSCREIPT : MonoBehaviour
{

    public GameObject keyboard;
    public GameObject hintButton;
    private bool ISTRIGGER = false;
    private RIDDELSCRIPT rs;
    private string answer;
    GameObject player;
    bool paused = false;
    [SerializeField] Text display;
    DataKeeper dk;

    // Start is called before the first frame update
    void Start()
    {
        rs = GetComponent<RIDDELSCRIPT>();
        ISTRIGGER = false;
        //deactivate ui
        keyboard.SetActive(false);
        hintButton.SetActive(false);

        dk = GameObject.FindGameObjectWithTag("DataKeeper").GetComponent<DataKeeper>();
    }


    // Update is called once per frame
    void Update()
    {
        if (ISTRIGGER) 
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (!paused)
                {
                    paused = true;
                    //activate ui
                    keyboard.SetActive(true);
                    hintButton.SetActive(false);
                    Cursor.lockState = CursorLockMode.None; // freeing the mouse pointer
                    player.GetComponent<PlayerController>().enabled = false; //disable movement
                    player.GetComponentInChildren<MouseLooker>().enabled = false; // disable camera movement
                }
                else
                {
                    //deactivate ui
                    keyboard.SetActive(false);
                    Cursor.lockState = CursorLockMode.Locked;// lock mouse
                    player.GetComponent<PlayerController>().enabled = true; // movement enabled
                    player.GetComponentInChildren<MouseLooker>().enabled = true; //camera movement enabled
                    paused = false;
                }
            }
            string displayText = dk.GetCurrentDoorPasswordWithID(1);
            displayText = displayText.Replace("0", string.Empty);
            display.text = displayText;
        }
    }

    private void OnTriggerEnter(Collider Player)
    {
        ISTRIGGER = true;
        player = Player.gameObject;
        hintButton.SetActive(true);       
    }

    private void OnTriggerExit(Collider player)
    {
        ISTRIGGER = false;
        this.player = null;
        hintButton.SetActive(false);
    }

}
