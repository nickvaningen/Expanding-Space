﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {

	public GameObject Freindly
	;
	public GameObject target;
	public GameObject follow;
	public Transform spanwer;
	public Sprite friendly;
	public  float speed = 5;
	public float distance = 1;
	private float targetx;
	private float x;
	private float targety;
	private float y;
	private Vector2 Q;
	public bool flip;
	public hitpoints health;
	public float lookingfield;
	SpriteRenderer sr;
	[SerializeField]
	GeneralControl toggeler;

	void Start(){
		target = GameObject.Find("Player");
		follow = GameObject.Find("following");
		sr = GetComponent<SpriteRenderer> ();
	}
	void Update () {
		//print(target);
		if (!toggeler.menuToggle)
		{


			targetx = target.transform.position.x;
			x = transform.position.x;
			//print(targetx);
			//transform.LookAt (target);
			//transform.Translate (Vector2.MoveTowards);
			if (target.name == "Player")
			{
				//print(GameObject.Find("Player"));
				Life();
			}
			else
			{
				target = GameObject.Find("Player");



			}

			if (flip)
			{

				gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
			}
			else if (!flip)
			{

				gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
			}

		}
	}


	void Life()
	{
        //print(health.health);
        if (health.health < 0)
        {
            
            SpriteChange();
            //Debug.Log("switch");
            SpanwEnemy();
            Destroy(this.gameObject);
        }
            

		if (x >= targetx + 0.5f && targetx >= x + lookingfield * -1)//link
		{
			x += -speed;
			//Xpos++;
			flip = false;

		}
		else if (x <= targetx - 0.5f && targetx <= x + lookingfield)//rechts
		{
			x += speed;
			flip = true;
		}
		transform.position = new Vector2(x, transform.position.y);

	}
	void SpriteChange(){
		sr.sprite = friendly;
	}
	void SpanwEnemy()
	{
		spanwer = GameObject.Find("following").transform;
		Instantiate (Freindly, spanwer.position, Quaternion.identity);
	}
	
}
