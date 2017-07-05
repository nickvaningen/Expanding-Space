﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anamation : MonoBehaviour {

	private ArrayList Animationlist;


	public Sprite idlesprite_1;
	public Sprite idlesprite_2;

	public Sprite walkingsprite_1;
	public Sprite walkingsprite_2;
	public Sprite walkingsprite_3;
	public Sprite walkingsprite_4;
	public Sprite walkingsprite_5;
	public Sprite walkingsprite_6;
	public Sprite walkingsprite_7;
	public Sprite walkingsprite_8;

	public Sprite shootingsprite_1;
	public Sprite shootingsprite_2;
	public Sprite shootingsprite_3;
	public Sprite shootingsprite_4;
	public Sprite shootingsprite_5;

	public Sprite hurtingsprite_1;
	public Sprite hurtingsprite_2;

	public Sprite jumpingsprite_1;
	public Sprite jumpingsprite_2;
	public Sprite jumpingsprite_3;
	public Sprite jumpingsprite_4;
	public Sprite jumpingsprite_5;


	public float timer = 0;
	public int index = 0;

	public void PlayLanded()
	{
		if (index == 1)
		{
			GetComponent<SpriteRenderer>().sprite = jumpingsprite_5;
			//print("allo");
		}
		else if (index == 2)
		{
			GetComponent<SpriteRenderer>().sprite = jumpingsprite_5;
			//print("allo 2");
		}
		else { index = 0; }
		index++;
	}

	// Use this for initialization
	public void Playidle () {
			if (index == 1)
			{
				GetComponent<SpriteRenderer>().sprite = idlesprite_1;
				//print("allo");
			}
			else if (index == 2)
			{
				GetComponent<SpriteRenderer>().sprite = idlesprite_2;
				//print("allo 2");
			}
			else { index = 0; }
			index++;
	}


	public void Playwalking() {
		switch (index) {

			case 1:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_1;
				break;
			case 2:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_2;
				break;
			case 3:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_3;
				break;
			case 4:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_4;
				break;
			case 5:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_5;
				break;
			case 6:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_6;
				break;
			case 7:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_7;
				break;
			case 8:
				GetComponent<SpriteRenderer>().sprite = walkingsprite_8;
				break;
		}
		if (index > 7) {
			index = 1;
		} else {
			index++;
		}
	}

	public void Playshooting(){
		switch (index)
		{
			case 1:
				GetComponent<SpriteRenderer>().sprite = shootingsprite_1;
				break;
			case 2:
				GetComponent<SpriteRenderer>().sprite = shootingsprite_2;
				break;
			case 3:
				GetComponent<SpriteRenderer>().sprite = shootingsprite_3;
				break;
			case 4:
				GetComponent<SpriteRenderer>().sprite = shootingsprite_4;
				break;
			case 5:
				GetComponent<SpriteRenderer>().sprite = shootingsprite_5;
				break;

		}
		if (index > 4)
		{
			index = 1;
		}
		else
		{
			index++;
		}
	}

	public void Playbeinghit(){
		if (index == 1)
		{
			GetComponent<SpriteRenderer>().sprite = hurtingsprite_1;
			//print("allo");
		}
		else if (index == 2)
		{
			GetComponent<SpriteRenderer>().sprite = hurtingsprite_2;
			//print("allo 2");
		}
		else { index = 0; }
		index++;
		//print(index);
	}

	public void Playjumping()
	{
		switch (index) {
			case 1:
				GetComponent<SpriteRenderer>().sprite = jumpingsprite_1;
				break;
			case 2:
				GetComponent<SpriteRenderer>().sprite = jumpingsprite_2;
				break;
			case 3:
				GetComponent<SpriteRenderer>().sprite = jumpingsprite_3;
				break;
		}
		if (index >= 4) {
			index = 4;
		}
		else
		{
			index++;
		}
	}



	// Update is called once per frame

}
