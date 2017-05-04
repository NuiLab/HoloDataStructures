using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToMethods : MonoBehaviour
{
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Methods Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Credit Scene
        SceneManager.LoadScene("Methods");
    }
}