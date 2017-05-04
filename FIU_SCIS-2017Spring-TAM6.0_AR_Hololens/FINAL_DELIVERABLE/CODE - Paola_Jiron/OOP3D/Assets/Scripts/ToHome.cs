using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToHome : MonoBehaviour
{
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Main Screen");
        loadImage.SetActive(true);
        //Loads Scene Manager to Credit Scene
        SceneManager.LoadScene("Menu");
    }
}
