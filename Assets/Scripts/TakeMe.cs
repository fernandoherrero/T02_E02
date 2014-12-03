using UnityEngine;
using System.Collections;

/**
 * Lets a key be taken. It does it by registering it in the player's
 * inventory when he/she gets close
 */
public class TakeMe : MonoBehaviour {

	// depends of this script's parent having a collider that is a trigger
	void OnTriggerEnter (Collider col) {

		// if the player got close...
		if (col.name == "player") {

			// let him/her take the key
			col.gameObject.GetComponent<Inventory>().key = true;
			Destroy(gameObject); // and destroy it
		}
	}
}
