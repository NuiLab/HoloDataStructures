using UnityEngine;
using System.Collections;

public class PickupAppear : MonoBehaviour {

    public GameObject[] objectPool;
    private int currentIndex = 0;
    // Use this for initialization
    void Start ()
    {
        NewRandomObject();
	}

    public void NewRandomObject()
    {
        int newIndex = Random.Range(0, objectPool.Length);
        while (newIndex == currentIndex)
        {
            newIndex = Random.Range(0, objectPool.Length);
        }
        // Deactivate old gameobject
        objectPool[currentIndex].SetActive(false);
        // Activate new gameobject
        currentIndex = newIndex;
        objectPool[currentIndex].SetActive(true);
    }
    // Update is called once per frame
    void Update ()
    {
	    if(objectPool[currentIndex].activeSelf == false)
        {
            NewRandomObject();
        }
	}
}
