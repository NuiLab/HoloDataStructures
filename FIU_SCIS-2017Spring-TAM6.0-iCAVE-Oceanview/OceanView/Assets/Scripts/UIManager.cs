using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

	public static UIManager singleton;

	public PlayerShip playerShip;

	public Text WindDirectionText;
	public Text WindStrengthText;
	public Text HelmPositionText;
	public Text ShipDirectionText;
	public Text ShipSpeedText;


	private void Awake(){
		if (singleton != null && singleton != this) {
			Destroy (this.gameObject);
		} else {
			singleton = this;
			DontDestroyOnLoad (this.gameObject);
		}
	}

	public void Update(){
		WindDirectionText.text = "Wind Direction: " + ActiveEnviroment.singleton.GetDirectionString();
		WindStrengthText.text = "Wind Strength: " + ActiveEnviroment.singleton.windStrength;

		if (playerShip.sinking == true) {
			ShipDirectionText.text = "Ship Speed: " + 0;
			HelmPositionText.text = "Helm Position: " + 0;
			ShipDirectionText.text = "Ship Crashed";
			return;
		}

		if(playerShip.helmPosition > .1 || playerShip.helmPosition < -.1)
			HelmPositionText.text = "Helm Position: " + playerShip.helmPosition;
		else
			HelmPositionText.text = "Helm Position: " + 0;
		
		ShipDirectionText.text = "Ship Speed: " + playerShip.shipSpeed * ActiveEnviroment.singleton.GetRealwindStrength();
		ShipSpeedText.text = "Ship Direction: " + playerShip.transform.rotation.y;
	}
}
