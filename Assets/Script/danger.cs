using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danger : MonoBehaviour {
	public float timer = 10;
	private bool iya = true;
	public GameObject me;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("danger")) {
			timer -= Time.deltaTime;
			if (iya) {
				me.transform.Rotate (0, 400, 0);
			}
			if (timer <= 0) {
				iya = false;
			}
		}
	}
}
