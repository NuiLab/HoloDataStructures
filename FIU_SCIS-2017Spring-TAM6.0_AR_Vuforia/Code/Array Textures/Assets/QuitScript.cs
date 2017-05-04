using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour {

	public void OptionsGame(){
		SceneManager.LoadScene ("Options");

	}

    public void ArraysModuleSelector()
    {
        SceneManager.LoadScene("animations_textures");
    }

	public void ARSelector(){
		SceneManager.LoadScene ("ARSelector");

	}

	public void MainMenuSelector(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void QuitGame(){
		Application.Quit ();
		Debug.Log ("Game is quitting");
}
}
