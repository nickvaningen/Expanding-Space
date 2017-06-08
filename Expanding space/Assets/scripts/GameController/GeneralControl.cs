using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralControl : MonoBehaviour {
	public bool menuToggle = false;
	public GameObject pauseScreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("escape")){
			menuToggle = !menuToggle;
			

	}
		pauseScreen.SetActive(menuToggle);
		if (menuToggle) {
			Time.timeScale = 0;
		} else { Time.timeScale = 1; }
}
}
