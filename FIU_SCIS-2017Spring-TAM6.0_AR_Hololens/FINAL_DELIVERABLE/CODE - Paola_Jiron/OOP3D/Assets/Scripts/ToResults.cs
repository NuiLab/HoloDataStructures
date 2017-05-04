using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToResults : MonoBehaviour
{
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Results Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Credit Scene
        SceneManager.LoadScene("Results");
    }
}