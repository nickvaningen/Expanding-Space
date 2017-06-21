using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour 
{

	[SerializeField]
	private int sceneIndex;

	void OnTriggerEnter2D(Collider2D other)
	{
	
		if (other.CompareTag ("player")) 
		{
			SceneManager.LoadScene(sceneIndex);
		}
	
	}

}
