using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour {

	// Update is called once per frame
	void OnSelect () {
        Debug.Log("CLICK > EXIT Application");
        //System closes the Application
        Application.Quit();
     }
}
