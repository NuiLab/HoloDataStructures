using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {

	//This script is urrently not in use

	public float scrollSpeed = .2f;
	public float scrollSpeed2 = .2f;

	void FixedUpdate(){
		float offset = Time.time * scrollSpeed;
		float offset2 = Time.time * scrollSpeed;
		gameObject.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, -offset2));
	}
}