using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	// Use this for initialization
	public float speed = 1;
	public float jumpForce = 12;
	private Rigidbody2D RB2D;
	private bool isGround;
	void Start () {
		RB2D = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float xInput = Input.GetAxis ("Horizontal");
		RB2D.velocity = new Vector2 (xInput * speed, RB2D.velocity.y);

		if (Input.GetKeyDown (KeyCode.UpArrow)&& isGround) {
			RB2D.velocity = new Vector2 (RB2D.velocity.x, jumpForce);
		}

		if (xInput > 0.1) {
			transform.localScale = new Vector3 (0.2f, 0.2f, 1);
		}

		if (xInput < -0.1) {
			transform.localScale = new Vector3 (-0.2f, 0.2f, 1);
		}
	
	}

	void OnCollisionEnter2D (Collision2D coll) {
		isGround = true;
	}

	void OnCollisionExit2D (Collision2D coll) {
		isGround = false;
	}

}
