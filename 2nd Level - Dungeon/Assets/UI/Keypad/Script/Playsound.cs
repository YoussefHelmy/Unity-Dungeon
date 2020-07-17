using UnityEngine;
using System.Collections;

public class Playsound : MonoBehaviour 

{



	public void Clicky (string c){
		GetComponent<AudioSource>().Play();
	}


}
