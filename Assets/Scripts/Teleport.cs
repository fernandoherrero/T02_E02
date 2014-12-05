using UnityEngine;
using System.Collections;

/**
 * Teleports up and down
 */
public class Teleport : MonoBehaviour {
	
	private Transform _transform; // player's tansform (works only with one player)

	void OnTriggerEnter (Collider col) {
		
		Debug.Log ("Called");
		
		// if the player got close...
		if (col.name == "player") {
			
			// if not cached, cache the player's transform
			if (_transform == null) {
				_transform = col.gameObject.GetComponent<Transform>();
			}

			// teleport to position
			_transform.Translate(
				0,
				(_transform.position.y >= 3) ? -3 : 3,
				0
			);
		}
	}
}
