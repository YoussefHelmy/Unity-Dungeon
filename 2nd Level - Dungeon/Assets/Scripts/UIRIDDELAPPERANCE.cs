using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRIDDELAPPERANCE : MonoBehaviour
{
    private bool ISTRIGGER = false;
    [SerializeField] private Image REDDELs;
    public GameObject v;
    public void Start()
    {
       REDDELs.enabled = false;
        v.SetActive(false); 
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
        ISTRIGGER = true;
        if (ISTRIGGER)
        {
            v.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider player)
    {
        ISTRIGGER = false;
        v.SetActive(false);
    }
    
}
