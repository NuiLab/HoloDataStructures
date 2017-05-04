using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ToArraysTutorial : MonoBehaviour {
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Arrays Tutorial Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Arrays Tutorial Scene
        SceneManager.LoadScene("ArraysTutorial");
    }
}
