using UnityEngine;
using System.Collections;

/**
 * Enables the trigger that sends the player up once he/she
 * is teleported down for the first time. Then it removes this
 * script, whose job is done
 */
public class EnableTriggerUp : MonoBehaviour {

	private GameObject triggerUp;

	// get the triggerUp gameObject
	void Start () {

		triggerUp = GameObject.Find ("triggerUp"); // needed to be active to find it
		triggerUp.SetActive (false); // deactivate it
	}
	
	void OnTriggerEnter (Collider col) {

		// if the player got close...
		if (col.name == "player") {

			triggerUp.SetActive (true); // activate triggerUp
			Destroy (this); // job done. Destroy this script instance
		}
	}
}

