using UnityEngine;
using System.Collections;

public class ActiveEnvironment : MonoBehaviour {



	public int windStrength;
	public float windStrengthModifier; //Takes windStrength and changes it into an internal float actually used for calculations.
	public float windStrengthAdditionModifier; //Changes the effect of the direction modifier on the real windstrength method.
	public int windDirection; //int representation of direction, currently only supports hard directions, will be edited in the future to allow all directions
	public static ActiveEnvironment singleton;

	public float tiltModifier;
	public float tiltSpeedModifier;

	public GameObject playerShip;


	private void Awake(){
		if (singleton != null && singleton != this) {
			Destroy (this.gameObject);
		} else {
			singleton = this;
			DontDestroyOnLoad (this.gameObject);
		}
	}

	public void update(){
		transform.position = playerShip.transform.position;
	}

	public void SetDirection(int x){
		if (x == 0 || x == 1 || x == 2 || x == 3) {
			windDirection = x;
		}
	}

	public string GetDirectionString(){
		switch (windDirection) {
		case 0:
			return "North";
		case 1:
			return "East";
		case 2:
			return "South";
		case 3: 
			return "West";
		default:
			print ("Unrecognized Direction Error");
			return "";
		}
	}

	public float GetRealwindStrength(){
		float directionModifier;
		float realRotation = playerShip.transform.rotation.y;
		print (realRotation);

		switch (windDirection) {
			case 0:
				realRotation -= Mathf.PI * 0.5f;
		    	break;
		    case 1:
			    break;
		    case 2:
				realRotation += Mathf.PI * 0.5f;
			    break;
		    case 3: 
				realRotation += Mathf.PI;
			    break;
			default:
				print ("Unrecognized Direction Error");
				directionModifier = 0;
				return 0;
		}

		//while (realRotation >= 2 * Mathf.PI) {
			//realRotation = -2 * Mathf.PI;
		//}

		realRotation = realRotation % 2 * Mathf.PI;

		if (realRotation < 0)
			realRotation += 2 * Mathf.PI; // fix for negative rotations since mod does not work correctly in this case.

		if (realRotation > Mathf.PI)
			realRotation = 2 * Mathf.PI - realRotation; //for this we need an angle less than 180, and if it's more than 180 we need to know how far from zero it is.

		directionModifier = 1 - (realRotation / Mathf.PI);
		return windStrength * windStrengthModifier * (directionModifier + windStrengthAdditionModifier);
	}
}



//add a method to correct z rotation over time, fix getwindstrength maybe, not sure if broken atm