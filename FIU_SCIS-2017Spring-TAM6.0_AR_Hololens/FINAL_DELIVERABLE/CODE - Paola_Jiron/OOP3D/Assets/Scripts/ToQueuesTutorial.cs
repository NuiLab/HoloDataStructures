using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ToQueuesTutorial : MonoBehaviour {
    public GameObject loadImage;
    // Update is called once per frame
    void OnSelect()
    {
        Debug.Log("CLICK > TO Queues Tutorial Scene");
        loadImage.SetActive(true);
        //Loads Scene Manager to Queues Tutorial Scene
        SceneManager.LoadScene("QueuesTutorial");
    }
}
