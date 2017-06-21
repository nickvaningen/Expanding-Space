using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public GameObject Player;
	private float _Xpos;
	private float _Ypos;
	public float movespeed = 0.05f;


	void Start()
	{
		_Ypos = transform.position.y;
		_Xpos = transform.position.x;
	}

	// Update is called once per frame
	void Update () {


		if (Player.transform.position.x >= transform.position.x + 1) {
			_Xpos += movespeed;

		} else if (Player.transform.position.x <= transform.position.x - 1)
		{
			_Xpos -= movespeed;
			

		}

		if (Player.transform.position.y >= transform.position.y + 2)
		{
			_Ypos += movespeed;

		}
		else if (Player.transform.position.y <= transform.position.y - 3)
		{
			_Ypos -= movespeed;


		}

		transform.position = new Vector3(_Xpos,_Ypos+2,-10);
	}




}
