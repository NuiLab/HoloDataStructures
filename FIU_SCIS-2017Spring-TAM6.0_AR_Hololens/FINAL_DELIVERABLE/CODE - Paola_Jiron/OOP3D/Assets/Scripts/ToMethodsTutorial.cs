using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ToMethodsTutorial : MonoBehaviour {
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Methods Tutorial Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Methods Tutorial Scene
        SceneManager.LoadScene("MethodsTutorial");
    }
}
