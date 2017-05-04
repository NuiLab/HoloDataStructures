using UnityEngine;
using System.Collections;

//Controls the player ship, similar code should be used for other ships
public class PlayerShip : MonoBehaviour {

	//Variables should be made private with [serializable] if the project starts to get more complicated

    /* Values range from -1 to 1 and determine the intensity of the turn towards the left or the right respectively. */
    public float helmPosition = 0f;
	public float shipSpeed = 1f;
	public bool sinking = false;
	public Transform[] collisionPoints;
	public GameObject playerCamera;

	// Use this for initialization
	void Start () {
		StartCoroutine (ShipFloatingEffect ());
	}
		
	void FixedUpdate () {

		if (sinking == false) {
			UpdateDirection (); //changes the direction of the ship
			UpdateHelmPosition (); //changes the position of the helm (the ship's "wheel")
			UpdateShipPosition (); //changes the position of the ship
			ShipFloatingEffect ();
			CorrectZAxis ();
			CheckForCollisions ();
		} else { //should all be updated by the next group to be more solid overall
			if (transform.position.y > -8f) {
				transform.Translate (0, -.005f, 0);
			}
			if (transform.rotation.x > 0 && transform.rotation.x < .3f) {
				ChangeShipOrientation (.0025f, 0);
			} else if (transform.rotation.x > -.25) {
				ChangeShipOrientation (-.0025f, 0);
			}
		}
		//PlayerFix ();
	}

	//When the player turns the ship
    void UpdateHelmPosition()
    {
        if (Input.GetKey(KeyCode.R) && helmPosition > -1f)
        {
            helmPosition -= .01f; //rotate the helm should be done whenever the helmPosition is changed
        }
        else if (Input.GetKey(KeyCode.T) && helmPosition < 1f)
        {
            helmPosition += .01f;
        }
        else if (helmPosition > 0f)
        {
            helmPosition -= .01f;
        }
        else if (helmPosition < 0f)
        {
            helmPosition += .01f;
        }
    }

    /* Updates the rotation of the ship based on the helm's position, which then also affects the direction the ship is sailing in. */
    void UpdateDirection()
    {
		gameObject.transform.Rotate (new Vector3 (0, .1f * helmPosition * GetRealShipSpeed(), 0));
    }

	//needs work
	/* Updates the ship's position based on it's rotation */
    void UpdateShipPosition()
    {

		float realRotation = gameObject.transform.rotation.y;
		while (realRotation >= 360) {
			realRotation = -360;
		}
		//float realRotation = gameObject.transform.rotation.y % 360; //get the real angle of rotation within 360 degrees
		if (realRotation < 0)
			realRotation += 360; // fix for negative rotations since mod does not work correctly in this case.

		float radians = realRotation * Mathf.PI / 180;
		float xAxis = (float) Mathf.Cos (radians);
		float zAxis = (float) Mathf.Sin (radians);

		float realSpeed = GetRealShipSpeed();

        //transform.position += transform.forward * Time.deltaTime * shipSpeed;

        transform.Translate (realSpeed * xAxis, 0, shipSpeed * zAxis);

		//z moves at 1 on 90 and 270 and 0 on 0 and 180
		//x is the opposite 

		if (transform.position.y != 0)
			transform.position = new Vector3 (transform.position.x, 0, transform.position.z);
    }


	//barely noticeable floating effect that should be expanded on by future students
	IEnumerator ShipFloatingEffect(){
		
		float listChange = 0;
		float tiltChange = 0;
		bool tiltingRight = false;

		while (sinking == false) {
			if (tiltingRight == true) { //if tilting one way, keep tilting the same way until you reach a certain point. Otherwise the ship will just spasm back and forth.
				listChange = .0025f * ActiveEnviroment.singleton.tiltSpeedModifier;
				ChangeShipOrientation (listChange, tiltChange);
				print (transform.rotation.x);
				yield return null;				
			} else {
				listChange = -.0025f * ActiveEnviroment.singleton.tiltSpeedModifier;
				ChangeShipOrientation (listChange, tiltChange);
				yield return null;				
			}

			if (transform.rotation.x < -.015f * ActiveEnviroment.singleton.tiltModifier && tiltingRight == false)
				tiltingRight = true;
			if (transform.rotation.x > .015f * ActiveEnviroment.singleton.tiltModifier && tiltingRight == true)
				tiltingRight = false;
		}
		
	}


	void ChangeShipOrientation(float changeList, float changeTilt){
		gameObject.transform.Rotate (new Vector3 (changeList, 0, changeTilt));			
	}
		
	void CorrectZAxis(){
		if (sinking == false && gameObject.transform.rotation.z != 0) {
			gameObject.transform.rotation.Set (transform.rotation.x, transform.rotation.y, 0, 0);
		}
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }

	float GetRealShipSpeed(){
		return shipSpeed * ActiveEnviroment.singleton.GetRealwindStrength();
	}

	//Checks for collisions using 4 raycasts. Using multiple raycasts makes it more consistant and can be used for other future features.
	void CheckForCollisions(){
		bool cast;
		cast = Physics.Raycast (collisionPoints [0].position, new Vector3(1,0,0), .25f);
		cast = cast || Physics.Raycast (collisionPoints [1].position, new Vector3(1,0,0), .25f);
		cast = cast || Physics.Raycast (collisionPoints [2].position, new Vector3(1,0,0), .25f);
		cast = cast || Physics.Raycast (collisionPoints [3].position, new Vector3(1,0,0), .25f);

		if (cast) {
			sinking = true;
			//StartCoroutine (ShakeCamera (2f));
		}

	}
		
	/* 
	IEnumerator ShakeCamera (float shakeDuration){
		Vector3 originalLocalPos = playerCamera.transform.localPosition;
		while (shakeDuration > 0)
		{
			playerCamera.transform.localPosition = originalLocalPos + Random.insideUnitSphere * 0.5f;
			shakeDuration -= Time.deltaTime;
			yield return null;
		}
		playerCamera.transform.localPosition = originalLocalPos;
	}

	*/



	// bandage fix for player
	/* void PlayerFix(){
		if (player.transform.position.y > 20) {
			player.velocity = Vector3.zero;
		}
	}
	*/

}
