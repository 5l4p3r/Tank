using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	public void ResetButton(){
		Application.LoadLevel ("Main");
	}
	public void Level2(){
		Application.LoadLevel ("Main2");
	}
	public void Level3(){
		Application.LoadLevel ("Main3");
	}
	public void Level4(){
		Application.LoadLevel ("Main4");
	}
	public void keSkin(){
		Application.LoadLevel ("SKIN");
	}
}
