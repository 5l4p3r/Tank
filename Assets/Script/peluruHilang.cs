using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluruHilang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("peluru")) {
			Destroy (other.gameObject, 0.01f);
		}
	}
}
