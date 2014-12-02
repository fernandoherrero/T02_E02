using UnityEngine;
using System.Collections;

public class AnimationCallbacks : MonoBehaviour {

	private Animation animationElevator;

	void Start () {
		animationElevator = GameObject.Find ("innerBox").GetComponent<Animation>();
	}

	// call when button starts being pressed
	public void SendElevatorDown() {
		Debug.Log ("send elevator down");
		// innerbox is the gameobject of elevator with the animation
		animationElevator.Play();
	}

	// call when button ends going back to it's original position
	public void SendElevatorUp() {
		Debug.Log ("send elevator up");
		// innerbox is the gameobject of elevator with the animation
		animationElevator.Play("elevatorUp");
	}
}
