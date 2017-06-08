using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocketman_ending : MonoBehaviour
{

	private LoadScenes loadscene;
	// Use this for initialization

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "Player")
		{
			print("fuck you!");
			SceneManager.LoadScene(2);
		}
	}

}