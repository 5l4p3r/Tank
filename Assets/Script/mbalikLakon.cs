using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mbalikLakon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("lakon")) {
			//other.gameObject.transform.Rotate (180, 0, 0);
			other.transform.rotation = Quaternion.identity;
		}
	}
}
