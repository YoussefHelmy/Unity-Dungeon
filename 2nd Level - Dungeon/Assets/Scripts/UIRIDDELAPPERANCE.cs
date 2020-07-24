using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRIDDELAPPERANCE : MonoBehaviour
{
    private bool ISTRIGGER = false;
    [SerializeField] private Image REDDELs;
    public GameObject RiddleCanvas;
    public void Start()
    {
       REDDELs.enabled = false;
        RiddleCanvas.SetActive(false); 
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.E) && ISTRIGGER == true)
        {

           REDDELs.enabled = true;
            
        }
        else
        {
            REDDELs.enabled = false;
        }

    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.transform.tag == "Player")
        {
            ISTRIGGER = true;
            if (ISTRIGGER)
            {
                RiddleCanvas.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider player)
    {
        ISTRIGGER = false;
        RiddleCanvas.SetActive(false);
    }
    
}
