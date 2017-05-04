using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToDataStructures : MonoBehaviour
{
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Data Structures Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Credit Scene
        SceneManager.LoadScene("DataStructures");
    }
}