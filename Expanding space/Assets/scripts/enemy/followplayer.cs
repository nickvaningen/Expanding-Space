using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {


	public GameObject target;
	public GameObject follow;
	public  float speed = 5;
	public float distance = 1;
	private float targetx;
	private float x;
	private float targety;
	private float y;
	private Vector2 Q;
	public bool flip;
	public hitpoints health;

	void Start(){

	}
	void Update () {
		//transform.LookAt (target);
		//transform.Translate (Vector2.MoveTowards);
		Life();


		if (flip)
		{
			
			gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
		}
		else if (!flip)
		{
			
			gameObject.transform.rotation = Quaternion.Euler(0,0,0);
		}
	
	}
	void Life()
	{
		switch (health.health) 
		{
		case 100:
			targetx = target.transform.position.x;
			x = transform.position.x;
			if(x >= targetx)//link
			{
				x += -speed;
				//Xpos++;
				flip = false;

			}else if(x <= targetx)//rechts
			{
				x += speed;
				flip = true;
			}
			transform.position = new Vector2 (x, transform.position.y);

			break;
		case  50:
			Debug.Log ("hat");
			targetx = target.transform.position.x;
			x = transform.position.x;
			if(x >= targetx)//link
			{
				x += -speed;
				//Xpos++;
				flip = false;

			}else if(x <= targetx)//rechts
			{
				x += speed;
				flip = true;
			}
			transform.position = new Vector2 (x, transform.position.y);

			break;
		case  0:
			Debug.Log ("switch");
			targety =follow.transform.position.x;
			y = transform.position.x;
			if(y >= targety)//link
			{
				y += -speed;
				//Xpos++;
				flip = false;

			}else if(y <= targety)//rechts
			{
				y += speed;
				flip = true;
			}
			transform.position = new Vector2 (y, transform.position.y);

			//targetx.transform.position.x += distance;
			break;
		default:
			Debug.Log("error");
			break;
		}

	}
}
