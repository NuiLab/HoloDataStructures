using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setMetAnswers : MonoBehaviour {
    private bool isSelected = false;
    float x = 0.0f, y = 0.0f, z = 0.0f, newX = 0.0f, newY = 0.0f, newZ = 0.0f;

    private void Start()
    {
        //intialize scale holders to handle resizing of objects on select (user feedback)
        x = transform.localScale.x;
        y = transform.localScale.y;
        z = transform.localScale.z;
        newX = x + (x / 2);
        newY = y + (y / 2);
        newZ = z + (z / 2);
    }

    void OnSelect()
    {
        if (this.gameObject.name == "Tools_Cube")                   this.resize(1);//Update preferences to Answer 1
        else if (this.gameObject.name == "CoffeeMaker_Container")   this.resize(2);//Update preferences to Answer 2
        else if (this.gameObject.name == "F(x)_Cube")               this.resize(3);//Update preferences to Answer 3
        else if (this.gameObject.name == "Graph_Cube")              this.resize(4);//Update preferences to Answer 4

        Debug.Log("TEST>>> Q2 Current answer is: " + PlayerPrefs.GetInt("Q2"));
    }

    //resizes the object on selection
    void resize(int ans)
    {
        Debug.Log(x + ", " + y + ", " + z + " | " + newX + ", " + newY + ", " + newZ);
        if (!isSelected)
        {
            transform.localScale = new Vector3(newX, newY, newZ);
            PlayerPrefs.SetInt("Q2", ans);
            isSelected = true;
        }
        else
        {
            transform.localScale = new Vector3(x, y, z);
            PlayerPrefs.SetInt("Q2", 0);
            isSelected = false;
        }
    }
}
