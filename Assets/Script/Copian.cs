using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copian : MonoBehaviour {

	public GameObject copy, paste, karantina;
	public float waktuCopy = 40;
	public float waktuHabis = 950;
	private bool iya = true;
	// Use this for initialization
	void Start () {
		waktuCopy = 5;
	}



	// Update is called once per frame
	void Update () {
		waktuCopy -= Time.deltaTime;
		waktuHabis -= Time.deltaTime;
		if (iya) {
			if (waktuCopy <= 0.0f) {
				waktuCopy = 40;
				paste = Instantiate (copy, transform.position, transform.rotation);
			}
		}
		if (waktuHabis <= 0.0f) {
			waktuHabis = 0.0f;
			iya = false;
			Destroy (karantina.gameObject, 0.01f);
		}
		
	}


}
