using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shoot : MonoBehaviour {
	
	
	public Rigidbody copy, paste;
	public float Speed;
	public AudioClip gun;
	AudioSource audiosource;
	public GameObject a1, a2;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		


		if (Input.GetKeyDown(KeyCode.Space)) {
			Tembak ();
			dor ();
		}
		
	}
	public void Tembak(){
		
		paste = Instantiate (copy, transform.position, transform.rotation);
		paste.velocity = transform.TransformDirection (Vector3.forward * Speed);
		Destroy (paste.gameObject, 2.0f);
		a2 = Instantiate (a1, transform.position, transform.rotation);
		Destroy (a2.gameObject, 3.0f);	
	}

	public void dor(){
		audiosource.PlayOneShot (gun);
	}

}
