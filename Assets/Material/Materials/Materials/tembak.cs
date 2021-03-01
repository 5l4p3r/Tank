using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tembak : MonoBehaviour {
	public Rigidbody copy, paste;
	public float waktuTembak = 2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		waktuTembak -= Time.deltaTime;
		if (waktuTembak <= 0) {
			waktuTembak = 2;
			paste = Instantiate (copy, transform.position, transform.rotation);
			paste.velocity = transform.TransformDirection (Vector3.forward * 300);
			Destroy (paste.gameObject, 1.0f);
		}
		
	}
}
