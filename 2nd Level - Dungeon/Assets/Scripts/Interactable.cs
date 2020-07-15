
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInteractable = false;
    public float radius = 3f;

    public void Update()
    {
        if (isInteractable && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Interact");
        }

    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    isInteractable = true;
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    isInteractable = false;
    //}
    private void OnTriggerEnter(Collider other)
    {
        
            isInteractable = true;
    }
    private void OnTriggerExit(Collider other)
    {

        isInteractable = false;
    }
    









    //void Update()
    //{
    //    Checks if the player is in the collider and also if the key is pressed.
    //    if (isInteractable && Input.GetKeyDown(KeyCode.F))
    //    {
    //        personalized code can go in here when activated.
    //        Debug.Log("Interact");
    //    }
    //}


    //private void OnTriggerEnter(Collider other)
    //{
    //    Compares the tag of the object entering this collider.
    //    if (other.tag == "Player")
    //    {
    //        turns on interactivity
    //        isInteractable = true;
    //    }
    //}





    //private void OnTriggerExit(Collider other)
    //{
    //    compares the tag of the object exiting this collider.
    //    if (other.tag == "Player")
    //    {
    //        turns off interactivity
    //        isInteractable = false;
    //    }
    //}
}