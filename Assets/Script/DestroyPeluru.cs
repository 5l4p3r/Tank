using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPeluru : MonoBehaviour {
	public GameObject paste;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("luar")) {
			Destroy (paste.gameObject, 0.0f);
		}
	}
}
