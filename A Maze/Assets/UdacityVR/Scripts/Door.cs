﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	private bool locked;
	private bool opening;

	public Door(){
		locked = true;
		opening = false;
	}


    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up

		if (opening) {
			if (transform.position.y < 8.0f) {
				transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
			}
		}
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked


		Debug.Log ("OnDoorClicked() has been called.");

		if (!locked) {
			opening = true;
		} else {

		}
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		Debug.Log("Door.Unlock() has been called");

		locked = false;
    }
}
