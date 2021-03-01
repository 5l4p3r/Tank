using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TembakanMusuh : MonoBehaviour {
	public Transform lakon;
	public float waktuTembak = 2;
	public Rigidbody copy, paste;
	public float Speed;
	public AudioClip ttttt;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Vector3.Distance (lakon.position, transform.position) < 100f) {
			waktuTembak -= Time.deltaTime;
			if (waktuTembak <= 0) {
				waktuTembak = 2;
				Tembak ();

			}
		}
		
	}
	public void Tembak(){
		paste = Instantiate (copy, transform.position, transform.rotation);
		paste.velocity = transform.TransformDirection (Vector3.forward * Speed);
		Destroy (paste.gameObject, 1.0f);
		audiosource.PlayOneShot (ttttt, 1.0f);
	}
}
