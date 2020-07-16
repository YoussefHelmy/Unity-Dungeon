
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInteractable = false;
<<<<<<< HEAD
  
=======
>>>>>>> 5a8d17e2f42f2239135a2c4217be6a6d897eb817

    public void Update()
    {
        if (isInteractable && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Interact");
        }

    }


<<<<<<< HEAD
=======
   
>>>>>>> 5a8d17e2f42f2239135a2c4217be6a6d897eb817
    private void OnTriggerEnter(Collider other)
    {
        
            isInteractable = true;
    }
    private void OnTriggerExit(Collider other)
    {

        isInteractable = false;
    }
    
<<<<<<< HEAD









   
=======
>>>>>>> 5a8d17e2f42f2239135a2c4217be6a6d897eb817
}