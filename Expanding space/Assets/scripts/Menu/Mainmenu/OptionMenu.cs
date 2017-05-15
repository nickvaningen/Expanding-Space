using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour {
	public GameObject soundMenu;
	public GameObject gameplayMenu;
	public int toggeler = 0;

	// Use this for initialization
	public void Switch_sound () {
		toggeler = 1;
	}

	public void Switch_gameplay()
	{
		toggeler = 0;
	}

	// Update is called once per frame
	void Update () {
		switch (toggeler) {
			case 1:
				soundMenu.SetActive(true);
				gameplayMenu.SetActive(false);
				break;
			case 0:
				gameplayMenu.SetActive(true);
				soundMenu.SetActive(false);
				break;
		}

	}
}
