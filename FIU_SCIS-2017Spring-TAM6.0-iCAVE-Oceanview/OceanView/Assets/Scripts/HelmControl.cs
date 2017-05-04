using UnityEngine;
using System.Collections;

//Not used anymore
public class HelmControl : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void HelmControls(){

	}

	public void OnTriggerStay(Collider collider){
		if (collider.gameObject.Equals (player)) {
			//show optio allowing the player to "use the wheel"?
		}
		
	}
}
