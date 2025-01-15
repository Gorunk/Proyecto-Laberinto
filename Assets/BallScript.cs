using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public float speed; 
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	private void FixedUpdate () {
        rb.linearVelocity = new Vector3(Input.acceleration.x * speed, 0, Input.acceleration.y * speed);
	}

  
}
