using UnityEngine;
using System.Collections;

public class OpenMe : MonoBehaviour {
	
	private Animation anim;
	private bool isClosed = true;
	private Inventory _inventory; // only for one player

	void Start() {

		anim = GetComponentInChildren<Animation>();
	}

	// coroutine. necessary for delays
	IEnumerator toggleDoor() {

		// open door
		anim.Play ("doorOpen");
		isClosed = false; // register that door is open
		yield return new WaitForSeconds (5);
		
		// after a while, close the door
		anim.Play ("doorClose");
		yield return new WaitForSeconds (1);
		isClosed = true; // once closed, register it
	}

	void OnTriggerEnter (Collider col) {

		// cache once the inventroy
		if (_inventory == null) {
			_inventory = col.gameObject.GetComponent<Inventory>();
		}

		// if he/she is the player, the door is closed and we have the key...
		if (isClosed && col.name == "player" && _inventory.key) {
			// use door
			StartCoroutine(toggleDoor());
		}
	}
}
