using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ToStacksTutorial : MonoBehaviour {
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Stacks Tutorial Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Stacks Tutorial Scene
        SceneManager.LoadScene("StacksTutorial");
    }
}
