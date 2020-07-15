
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInteractable = false;

    public void Update()
    {
        if (isInteractable && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Interact");
        }

    }


   
    private void OnTriggerEnter(Collider other)
    {
        
            isInteractable = true;
    }
    private void OnTriggerExit(Collider other)
    {

        isInteractable = false;
    }
    
}