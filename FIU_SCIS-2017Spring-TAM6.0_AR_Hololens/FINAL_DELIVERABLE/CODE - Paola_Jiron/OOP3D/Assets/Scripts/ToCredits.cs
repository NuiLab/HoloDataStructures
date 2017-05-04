using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToCredits : MonoBehaviour
{
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Credits Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Credit Scene
        SceneManager.LoadScene("Credits");
    }
}
