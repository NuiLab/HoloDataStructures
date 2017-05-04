using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarColorChanger : MonoBehaviour {

    // Declare Renderer Object to allow input of 'star variable' object into script
    public Renderer StarObject;


	// Update is called once per frame
	void Update () {
        
        // Find UI Element For 'SelectedColor'
        Image img = GameObject.Find("SelectedColor").GetComponent<Image>();
        // Set the material color and emission fields to the same color as the UI Element
        StarObject.material.SetColor("_Color", img.canvasRenderer.GetColor());
        StarObject.material.SetColor("_EmissionColor", img.canvasRenderer.GetColor());
    }
}
