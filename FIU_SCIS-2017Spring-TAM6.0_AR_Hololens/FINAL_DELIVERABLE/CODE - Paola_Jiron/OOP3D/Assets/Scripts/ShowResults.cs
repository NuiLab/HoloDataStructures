using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowResults : MonoBehaviour {
    private GameObject ans1;
    private GameObject ans2;
    private GameObject ans3;
    int aa1;
    int aa2;
    int aa3;

    List<GameObject> sceneObjects = new List<GameObject>(); // list of all existing objects in every scene

    // Process during play mode
    // Handles player selection and display these on the results scene
    void Start() {

        aa1 = PlayerPrefs.GetInt("Q1");
        aa2 = PlayerPrefs.GetInt("Q2");
        aa3 = PlayerPrefs.GetInt("Q3");
        
        string[] a1 = new string[] { "Error1" ,"Cube_Vars_Text", "Cube_QMark", "Liquid Bulan","Sphere"};
        string[] a2 = new string[] { "Error2", "Tools_Cube", "CoffeeMaker_Container", "F(x)_Cube", "Graph_Cube"};
        string[] a3 = new string[] { "Error3", "Queue_Cube", "Stack_Container", "Drawers","Train_Container"};

        this.FindAll();

        foreach (GameObject obj in sceneObjects)
        {
            if (obj.name.Equals(a1[aa1])||obj.name.Equals(a2[aa2])||obj.name.Equals(a3[aa3]))
            {
                obj.SetActive(true);
            }
        }
    }
    // Finds the list of objects currently on the Results scene and creates a list of all of these objects
    //TODO Optimize list of objects from scene
    private void FindAll()
    {
        Object[] tempList = Resources.FindObjectsOfTypeAll(typeof(GameObject));
        List<GameObject> realList = new List<GameObject>();
        GameObject temp;

        foreach (Object obj in tempList)
        {
            if (obj is GameObject)
            {
                temp = (GameObject)obj;
                if (temp.hideFlags == HideFlags.None)
                    realList.Add((GameObject)obj);
            }
        }
        sceneObjects = realList;    // save objects
    }
}
