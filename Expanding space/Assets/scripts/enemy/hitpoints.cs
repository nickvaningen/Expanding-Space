using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitpoints : MonoBehaviour {

	[SerializeField]
	public int health = 100;
	private int _damage = 50;
	private float x;

	void Update () {
		x = transform.position.x;
	}
	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "Shootingstar"){
			health -= _damage;
		}
		if (health < 0) {
		  Destroy (this.gameObject);
		}
	}


}
