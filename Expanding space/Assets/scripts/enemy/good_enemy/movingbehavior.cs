using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingbehavior : MonoBehaviour 
{
	public GameObject follow;
	private float targetx;
	private float x;
	public float speed = 5;
	public bool flip;
	private Vector2 H;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		targetx = GameObject.Find("Player").transform.position.x;
		x = transform.position.x;

		if (flip)
		{

			gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
		}
		else if (!flip)
		{

			gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
		}

		//print (targetx);
		if (x >= targetx - 3f)//link
		{
			x += -speed;
			flip = false;

		}
		else if (x <= targetx - 4f )//rechts
		{
			x += speed;
			flip = true;
		}
		else
		{
			//flip = true;
		}
		transform.position = new Vector2 (x, transform.position.y);

	}
}
