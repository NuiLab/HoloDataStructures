using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ToVariableTutorial : MonoBehaviour{
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Variable Tutorial Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Variable Tutorial Scene
        SceneManager.LoadScene("VariableTutorial");
    }
} 