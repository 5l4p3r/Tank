using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Mati : MonoBehaviour {
	
	public AudioClip bomb;
	AudioSource audiosource;

    public Text sisa;

	public GameObject amun, amun1;

	private int kena;
	public GameObject musuh,copy,paste,aa,bb;
	public int yangmati;
 
	public GameObject camabis,resetButton,textMenang,lakon;
	public int jumlahtankMusuh = 26;


	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		yangmati = GameObject.FindGameObjectsWithTag ("bajingan").Length;
		int dikurangi = jumlahtankMusuh - yangmati;
		sisa.text = dikurangi.ToString ();
		//Debug.Log ("yang mati = " + yangmati);

		if (yangmati >= 25) {
			camabis.SetActive (true);
			resetButton.SetActive (true);
			lakon.SetActive (false);
			textMenang.SetActive (true);

		}


		if (kena >= 15) {

			bb = Instantiate (aa, transform.position, transform.rotation);
			paste = Instantiate (copy, transform.position, transform.rotation);
			amun1 = Instantiate (amun, transform.position, transform.rotation);
			Destroy (amun1.gameObject, 20.0f);
			Destroy (musuh.gameObject, 0.0f);
            Destroy (paste.gameObject, 40f);
            audiosource.PlayOneShot (bomb);
	
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("peluru")) {
			kena += 1;
		}

		if (other.gameObject.CompareTag ("missile")) {
			bb = Instantiate (aa, transform.position, transform.rotation);
			paste = Instantiate (copy, transform.position, transform.rotation);
			Destroy (musuh.gameObject, 0.0f);
			Destroy (paste.gameObject, 50f);

		}


	}
}
