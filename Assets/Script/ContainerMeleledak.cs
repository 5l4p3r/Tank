using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerMeleledak : MonoBehaviour {
	private int kena;
	public GameObject container,copy,paste;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (kena >= 8) {
			paste = Instantiate (copy, transform.position, transform.rotation);
			Destroy (paste.gameObject, 100f);
			Destroy (container.gameObject, 0.0f);
		}
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("peluru")) {
			kena += 1;
		}
	}
}
