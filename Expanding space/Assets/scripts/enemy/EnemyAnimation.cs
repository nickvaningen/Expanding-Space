using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour {
	int index;

	public Sprite idlesprite_1;
	public Sprite idlesprite_2;

	public Sprite attacksprite_1;
	public Sprite attacksprite_2;
	public Sprite attacksprite_3;
	public Sprite attacksprite_4;
	public Sprite attacksprite_5;
	public Sprite attacksprite_6;
	public Sprite attacksprite_7;

	public Sprite jumpingsprite_1;
	public Sprite jumpingsprite_2;
	public Sprite jumpingsprite_3;
	public Sprite jumpingsprite_4;
	public Sprite jumpingsprite_5;
	public Sprite jumpingsprite_6;

	public Sprite walkingsprite_1;
	public Sprite walkingsprite_2;
	public Sprite walkingsprite_3;
	public Sprite walkingsprite_4;
	public Sprite walkingsprite_5;
	public Sprite walkingsprite_6;
	public Sprite walkingsprite_7;
	public Sprite walkingsprite_8;

	public Sprite hitSprite_1;
	public Sprite hitSprite_2;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}



	public void PlayIdle()
	{

		if (index == 1)
		{
			GetComponent<SpriteRenderer>().sprite = idlesprite_1;

		}
		else if (index == 2)
		{
			GetComponent<SpriteRenderer>().sprite = idlesprite_2;

		}
		else {
			index = 0;
		}
		index++;
	}

	public void PlayWalking()
	{
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
		if (index > 7)
		{
			index = 1;
		}
		else
		{
			index++;
		}
	}

	public void PlayAttack()
	{
		switch (index) {
			case 1:
				GetComponent<SpriteRenderer>().sprite = attacksprite_1;
				break;
			case 2:
				GetComponent<SpriteRenderer>().sprite = attacksprite_2;
				break;
			case 3:
				GetComponent<SpriteRenderer>().sprite = attacksprite_3;
				break;
			case 4:
				GetComponent<SpriteRenderer>().sprite = attacksprite_4;
				break;
			case 5:
				GetComponent<SpriteRenderer>().sprite = attacksprite_5;
				break;
			case 6:
				GetComponent<SpriteRenderer>().sprite = attacksprite_6;
				break;
			case 7:
				GetComponent<SpriteRenderer>().sprite = attacksprite_7;
				break;
		}
		if (index > 6) {
			index++;
		}
		else {
			index++;
		}
	}

	public void PlayHit(){
		if (index == 1)
		{
			GetComponent<SpriteRenderer>().sprite = hitSprite_1;
			//print("allo");
		}
		else if (index == 2)
		{
			GetComponent<SpriteRenderer>().sprite = hitSprite_2;
			//print("allo 2");
		}
		else { index = 0; }
		index++;
		//print(index);
		}

	public void PlayJump()
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
		if (index > 3)
		{
			index = 1;
		}
		else
		{
			index++;
		}
	}
}
