using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BernhardBewegung : MonoBehaviour {

	// Use this for initialization
	public float speed = 8;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);
		if (transform.position.x > 5) {
			transform.position = new Vector3 (-5, transform.position.y, transform.position.z);
		}	
	}
}
