using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonControl : MonoBehaviour {
	public int page;
	public GameObject btn1, btn2, btn3;

	// Use this for initialization
	void Awake(){
		page = 1;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (page);
		
		if (page == 1) {
			btn1.SetActive (true);
			btn2.SetActive (false);
			btn3.SetActive (false);
		}
		if (page == 2) {
			btn1.SetActive (false);
			btn2.SetActive (true);
			btn3.SetActive (false);
		}
		if (page == 3) {
			btn1.SetActive (false);
			btn2.SetActive (false);
			btn3.SetActive (true);
		}
	}
	public void next(){
		int kanan;
		page += 1;
		if (page >= 4) {
			page = 1;
		} else {
			kanan = 1;
		}
	}
	public void pre(){
		int kiri;
		page -= 1;
		if (page <= 0) {
			page = 3;
		} else {
			kiri = 1;
		}
	}


	public void Level1(){
		Application.LoadLevel ("Main");
	}
	public void Level2(){
		Application.LoadLevel ("Main2");
	}
	public void Level3(){
		Application.LoadLevel ("Main3");
	}

}
