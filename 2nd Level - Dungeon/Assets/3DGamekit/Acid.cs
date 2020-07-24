using UnityEngine;

public class Acid : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Died");
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().GameLost();
        }
    }
    
      
    
    
        
}
