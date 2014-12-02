using UnityEngine;
using System.Collections;

public class OpenMe : MonoBehaviour {
	
	private Animation anim;
	private bool isClosed = true;

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
		string name = col.name.ToLower();

		// if door is closed and we have the key
		if (isClosed && name.StartsWith("player") &&
		    	col.gameObject.GetComponent<Inventory>().key) {
			// use door
			StartCoroutine(toggleDoor());
		}
	}
}
