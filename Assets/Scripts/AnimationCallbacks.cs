using UnityEngine;
using System.Collections;

/**
 * Holds animation callbacks for the elevator to go up and down at
 * the right moments of the button animation
 */
public class AnimationCallbacks : MonoBehaviour {

	private Animation animationElevator;

	void Start () {

		// save the Animation component of the elevator
		animationElevator = GameObject.Find ("innerBox").GetComponent<Animation>();
	}

	// callback - when button starts being pressed
	public void SendElevatorDown() {

		// play default animation, expected to be elevatorDown
		animationElevator.Play();
	}

	// callback - when button ends going back to it's original position
	public void SendElevatorUp() {

		// innerbox is the gameobject of elevator with the animation
		animationElevator.Play("elevatorUp");
	}
}
