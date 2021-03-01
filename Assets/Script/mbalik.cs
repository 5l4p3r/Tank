using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mbalik : MonoBehaviour {
	public Transform lakon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("brengsek")) {
			other.gameObject.transform.LookAt (lakon);
		}
	}
}
