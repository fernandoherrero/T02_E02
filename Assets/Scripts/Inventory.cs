using UnityEngine;
using System.Collections;

/**
 * Represents the player's inventory
 */
public class Inventory : MonoBehaviour {

	// first room key
	private bool _key = false;
	public bool key
	{
		set { this._key = value; }
		get { return this._key; }
	}
}
