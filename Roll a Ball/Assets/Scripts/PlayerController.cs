using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //Check every frame for player input
    //Update is called before rendering a game (most game code goes here)
    //private void Update()
    //{

    //}
    private Rigidbody rb;
    public float speed;
    public float up;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //run before any phisics calculations go
    //we will be inserting our physics code here
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, up, moveVertical);
        rb.AddForce(movement * speed*2);

    }
    private void Update()
    {
        if (Input.GetButtonDown("f"))
        {
            up = up - 100;
        }
    }
}
