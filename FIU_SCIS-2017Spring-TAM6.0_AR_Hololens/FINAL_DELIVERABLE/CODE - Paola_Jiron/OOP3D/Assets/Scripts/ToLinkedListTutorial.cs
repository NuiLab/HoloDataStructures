using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ToLinkedListTutorial : MonoBehaviour {
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Linked List Tutorial Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Linked List Tutorial Scene
        SceneManager.LoadScene("LinkedListTutorial");
    }
}
