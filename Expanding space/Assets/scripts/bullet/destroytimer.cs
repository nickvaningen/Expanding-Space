using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroytimer : MonoBehaviour {

	public GameObject bullet;
	void Start () 
	{
		Destroy (bullet, 5f);
	}
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "enemy")
			Destroy (this.gameObject);
		
	}
}
