using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gueMati : MonoBehaviour {
	public int nyawa = 30;
	public Slider nyawaBar;
	public int kena;
	public GameObject camabis, textKalah, resetButton,lakon;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		nyawaBar.value = nyawa;
		Debug.Log ("kena = " + kena);
		if (kena >= 30) {
			textKalah.SetActive (true);
			camabis.SetActive (true);
			resetButton.SetActive (true);
			lakon.SetActive (false);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("pelurumusuh")) {
			kena += 1;
			nyawa -= 1;
			Handheld.Vibrate ();
		}
		if (other.gameObject.CompareTag ("bajingan")) {
			kena = 0;
			nyawa = 30;
		}
	}

	public void Reset(){
		Application.LoadLevel ("Main");
		resetButton.SetActive (false);
		textKalah.SetActive (false);
		camabis.SetActive (false);
	}
}
