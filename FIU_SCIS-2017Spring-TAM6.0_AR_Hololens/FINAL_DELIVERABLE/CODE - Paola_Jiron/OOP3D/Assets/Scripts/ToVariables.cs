using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToVariables : MonoBehaviour
{
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Variables Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Variables Scene
        SceneManager.LoadScene("Variables");
    }
}
