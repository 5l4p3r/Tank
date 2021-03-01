using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meledak : MonoBehaviour {
	public GameObject copy, paste;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("peluru") || other.gameObject.CompareTag ("pelurumusuh")) {
			paste = Instantiate (copy, other.gameObject.transform.position, other.gameObject.transform.rotation);
			Destroy (paste.gameObject, 2.0f);
		}
	}
}
