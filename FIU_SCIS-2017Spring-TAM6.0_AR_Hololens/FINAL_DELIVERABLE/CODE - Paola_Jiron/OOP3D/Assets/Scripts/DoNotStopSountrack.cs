using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotStopSountrack : MonoBehaviour {

    private static DoNotStopSountrack instance = null;
    public static DoNotStopSountrack Instance
    {
        get
        {
            return instance;
        }
    }

	// Use this for initialization
    // Loops the sound through scenes nonstop and without interruption until game application is terminated
	void Awake () {

        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
	}
}
