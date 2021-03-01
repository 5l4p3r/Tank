using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodaPutar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Rotate (0, 0, 90 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Rotate (0, 0, -90 * Time.deltaTime);
		}
	}
}
