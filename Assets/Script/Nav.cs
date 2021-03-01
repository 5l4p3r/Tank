using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nav : MonoBehaviour {
	public GameObject LdriveWheel,RdriveWheel;
	public GameObject Lidler, Ridler;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, 30 * Time.deltaTime,0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0, -30 * Time.deltaTime,0);
		}
	}
}
