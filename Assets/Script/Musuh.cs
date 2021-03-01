using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musuh : MonoBehaviour {
	public Transform lakon;
	public GameObject bajingan;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (lakon.position, transform.position) <= 150f) {
			transform.Translate (0, 0, 0);
			transform.LookAt (lakon);


		} else {
			transform.Translate (0, 0, 10 * Time.deltaTime);

		}
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("luar")) {
			bajingan.transform.Rotate (0, 100, 0);
		}
	}
}
