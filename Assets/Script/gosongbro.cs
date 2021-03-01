using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gosongbro : MonoBehaviour {
	public int kena;
	public GameObject building, gosong;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (kena >= 30) {
			building.SetActive (false);
			gosong.SetActive (true);
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("peluru")) {
			kena += 1;
		}
	}
}
