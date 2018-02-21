using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour {

    //we need to refer to the GameObject we created - player. To do this create instance variable.
    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //take the current transform position on the camera and subtract it from the player game objects
        offset = transform.position - player.transform.position;
		
	}
	
	// LateUpdate is called once per frame, but after all items have been processed in update
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
