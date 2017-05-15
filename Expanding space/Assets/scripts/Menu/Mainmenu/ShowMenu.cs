using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour {

	public GameObject toggle_object;
	public bool toggle;

	// Use this for initialization
	public void Switch () {
		toggle = !toggle;
	}
	
	// Update is called once per frame
	void Update () {
		if (toggle)
		{
			toggle_object.SetActive(true);
		}
		else
		{
			toggle_object.SetActive(false);
		}
	}
}
