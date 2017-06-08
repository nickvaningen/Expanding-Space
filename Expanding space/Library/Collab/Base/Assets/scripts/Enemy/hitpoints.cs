using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitpoints : MonoBehaviour {

	[SerializeField]
	public int _hitpoints = 100;
	private int _damage = 50;
	private float x;

	void Update () {
		x = transform.position.x;
	}
	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "Shootingstar"){
			_hitpoints -= _damage;
		}
		//if (other.gameObject.tag == "player") {
		//	Destroy (this.gameObject);
		//}
		//if (_hitpoints < 0) {
		//  Destroy (this.gameObject);
		//}
		//if (_hitpoints < 50) {
		//	Debug.Log (_hitpoints);
		//}

	}

	void life()
	{
		switch (_hitpoints) 
		{
		case 50:
			Debug.Log ("halfhealt");
			break;
		case 0:
			Debug.Log ("switch");
			transform.position = new Vector2 (x - 2, transform.position.y);
			//Destroy (this.gameObject);
			break;
		default:
			Debug.Log("error");
			break;
		}

	}
}
