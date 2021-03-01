using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour {
	public GameObject pauseButton, resumeButton,buttonNavigasi;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void gamePause(){
		buttonNavigasi.SetActive (false);
		Time.timeScale = 0;
		pauseButton.SetActive (false);
		resumeButton.SetActive (true);
	}
	public void gameResume(){
		buttonNavigasi.SetActive (true);
		Time.timeScale = 1;
		pauseButton.SetActive (true);
		resumeButton.SetActive (false);
	}
}
