using UnityEngine;
using System.Collections;

public class createAmmoBots : MonoBehaviour {
	

	public GameObject bot;
	public GameObject bot2;



	void Start() {

		//spawned one. could not figure out spawning 10 seperate objects.

		GameObject botSpawn5 = (GameObject)Instantiate(bot, new Vector3(13,0,-10), transform.rotation);

		GameObject botSpawn = (GameObject)Instantiate(bot2, new Vector3(25,2,0), transform.rotation);
	}



		


	
	void Update() {
	}
}