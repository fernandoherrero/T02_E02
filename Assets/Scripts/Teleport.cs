using UnityEngine;
using System.Collections;

/**
 * Teleports up and down
 */
public class Teleport : MonoBehaviour {
	
	private Transform _transform; // player's tansform (works only with one)
	[SerializeField]
	private float pos;
	[SerializeField]
	private inLoop;

	void OnTriggerEnter (Collider col) {

		// if the player got close...
		if (col.name == "player") {

			// if not cached, cache the player's transform
			if (_transform == null) {
				_transform = col.gameObject.GetComponent<Transform>();
			}

			// teleport to position
			if (!inLoop) {
				inLoop = true; // let pass once (expected to start in false then)
			} else {
				_transform.position  = new Vector3(
					_transform.position.x, pos, _transform.position.z);
			}
		}
	}
}
