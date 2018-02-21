using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderControl : MonoBehaviour {

    public float thrust;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(10.0f, 0.0f, 5.0f);
        thrust++;
    }
}
