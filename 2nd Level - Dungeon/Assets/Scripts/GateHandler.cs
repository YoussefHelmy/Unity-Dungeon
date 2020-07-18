using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateHandler : MonoBehaviour
{

    [SerializeField] DataKeeper dk;
    [SerializeField] int doorID;
    public AudioClip openSFX;
    Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        dk = GameObject.FindGameObjectWithTag("DataKeeper").GetComponent<DataKeeper>();
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!(dk.CheckedLockedWithDoorID(doorID)))
            {
                anime.SetTrigger("OpenDoor");
                GetComponent<AudioSource>().PlayOneShot(openSFX);
            }
        }
    }



}
