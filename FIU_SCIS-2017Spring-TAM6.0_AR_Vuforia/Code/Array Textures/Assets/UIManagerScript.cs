using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene ("MainMenu");

}

	public GameObject musicPlayer;
	void Awake() {
	
		musicPlayer = GameObject.Find ("");

		if (musicPlayer == null) {

			musicPlayer = this.gameObject;
			musicPlayer.name = "Background_Audio";
		} else {

			if (this.gameObject.name != "Background_Audio") {
				Destroy (this.gameObject);
			}
		}

	}

	void Update(){
	}

}

