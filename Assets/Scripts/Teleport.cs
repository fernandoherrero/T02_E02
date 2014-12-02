using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	private bool isUp = true;

	void OnTriggerEnter (Collider col) {
		// if the player got close...
		if (col.name == "player") {
			Transform _transform = col.gameObject.GetComponent<Transform>();
			// teleporting down one floor
			Debug.Log ("Y: ");
			_transform.position = new Vector3(
				_transform.position.x, (isUp) ? 1.1f : 4.1f, _transform.position.z);

			isUp = !isUp;
		}
	}
}
