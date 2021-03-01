using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileYeah : MonoBehaviour {

	public Rigidbody miscopy,mispaste;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void missile(){

		mispaste = Instantiate (miscopy, transform.position, transform.rotation);
		mispaste.velocity = transform.TransformDirection (Vector3.forward * 300);
		Destroy (mispaste.gameObject, 4.0f);
	}
}
