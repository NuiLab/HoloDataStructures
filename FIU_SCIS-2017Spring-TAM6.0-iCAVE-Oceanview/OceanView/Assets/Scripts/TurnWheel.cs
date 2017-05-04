using UnityEngine;
using System.Collections;

//This script can be eliminated and the rotation made into a function called by "UpdateHelmPosition" in PlayerShipMovement. 
public class TurnWheel : MonoBehaviour
{
    public float wheelRotation = 0f;
    private float helmPos;
    GameObject wheel;

    // Update is called once per frame
    void FixedUpdate ()
    {
        GameObject helm = GameObject.Find("PlayerShipController");
        PlayerShip shipScript = helm.GetComponent<PlayerShip>();
        helmPos = shipScript.helmPosition;
        UpdateWheel();
        UpdateRotation();
    }
		
	//Functions needs work I recommend using a -1 to 1 value to sync it with the actual helm. Bandaged it to work correctly more or less, though.
    void UpdateWheel()
    {
		if (helmPos < -.95f && Input.GetKey (KeyCode.R) || helmPos > .95f && Input.GetKey (KeyCode.T) || helmPos > -.01f && helmPos < .01f && !Input.GetKey (KeyCode.R) && !Input.GetKey (KeyCode.T) ) {
			wheelRotation = 0f;
			return;
		}

		if (Input.GetKey (KeyCode.R) && wheelRotation > -5f && helmPos > -1f) {
			wheelRotation -= .05f;
		} else if (Input.GetKey (KeyCode.T) && wheelRotation < 5f && helmPos < 1f) {
			wheelRotation += .05f;
		} else if (helmPos > .1f) {
			wheelRotation -= .05f;
		} else if (helmPos < -.1f) {
			wheelRotation += .05f;
		} //else if (helmPos > -.01f && helmPos < .01f){ //unneeded
			//wheelRotation = 0;
		//}
    }

    void UpdateRotation()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, wheelRotation));
    }
}