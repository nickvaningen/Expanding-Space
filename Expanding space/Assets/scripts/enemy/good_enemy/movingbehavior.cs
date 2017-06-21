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
		targetx = GameObject.FindWithTag("following").transform.position.x;
		x = transform.position.x;
		print (targetx);
		if(x >= targetx)//link
		{
			x += -speed;
			flip = false;

		}else if(x <= targetx)//rechts
		{
			x += speed;
			flip = true;
		}
		transform.position = new Vector2 (x, transform.position.y);

	}
}
