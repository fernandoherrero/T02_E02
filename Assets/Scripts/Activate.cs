using UnityEngine;
using System.Collections;

/**
 * Calls the elevator and manages when it goes up agiain
 */
public class Activate : MonoBehaviour {

	void OnTriggerEnter (Collider col) {

		// if the player got close...
		if (col.name == "player") {

			// push button: send elvator down by staring the animation
			gameObject.GetComponentInChildren<Animation>().Play();
		}
	}
}
