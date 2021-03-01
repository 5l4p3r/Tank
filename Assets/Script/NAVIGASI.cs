using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NAVIGASI : MonoBehaviour {
	public GameObject ltrak, rtrak;



	public GameObject LdriveWheel,RdriveWheel;
	//public Slider vert;
	public Slider vert, hor;
	public GameObject laras;

	public int jumlahPeluru;
	public GameObject buttonShoot;
	public Text jumlah;



	// Use this for initialization
	void Start () {
		
		jumlahPeluru = 0;
	}
	
	// Update is called once per frame
	void Update () {
		jumlah.text = jumlahPeluru.ToString ();
		if (jumlahPeluru <= 0) {
			jumlahPeluru = 0;
			buttonShoot.SetActive (false);

		}

		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}

	
		float majumundur = vert.value;
		float kirikanan = hor.value;


		transform.Translate (0, 0, majumundur * Time.deltaTime);
		transform.Rotate (0, kirikanan * Time.deltaTime,0);


		LdriveWheel.transform.Rotate (90 * majumundur * Time.deltaTime, 0, 0);
		RdriveWheel.transform.Rotate (90 * majumundur * Time.deltaTime, 0, 0);

	}


	public void Ngurangi(){
		jumlahPeluru -= 1;
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("amunisi")) {
			jumlahPeluru += 6;
			buttonShoot.SetActive (true);

		}
	}

}
