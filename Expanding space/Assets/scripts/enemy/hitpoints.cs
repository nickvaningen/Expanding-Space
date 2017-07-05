using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitpoints : MonoBehaviour {

	[SerializeField]
	public float health = 100;
	private int _damage = 25;
    public int scoreValue = 10;
    private float x;

	void Update () {
		x = transform.position.x;
	}
	 public void hit(){

		health -= _damage;

		if (health < 0) {

        }
	}
    

}
