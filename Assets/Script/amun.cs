using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,90 * Time.deltaTime,0);
		transform.Translate (0, 10 * Time.deltaTime,0);
		
	}
}
