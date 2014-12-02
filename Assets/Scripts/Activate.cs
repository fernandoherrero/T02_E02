using UnityEngine;
using System.Collections;

public class Activate : MonoBehaviour {

	void OnTriggerEnter (Collider col) {
		// if the player got close...
		if (col.name == "player") {
			Debug.Log ("push button: send elvator down by staring the animation");
			gameObject.GetComponentInChildren<Animation>().Play();

			// push the button
			// col.gameObject.GetComponentInChildren<Animation>().Play();
		}
	}
}
