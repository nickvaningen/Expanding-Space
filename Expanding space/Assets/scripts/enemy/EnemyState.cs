using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour {

	public enum Enemystate {Walking, Idle, Atacking, Jumping, Hit, Null };
	Enemystate _EnemyCurrentState = Enemystate.Null;

	[SerializeField]
	private float lookingfield;
	public bool flip;
	private float targetx;
	private float x;
	private float y;
	private float targety;

	[SerializeField]
	float _timeridle = 0.15f;
	[SerializeField]
	float _timerwalking = 0.05f;
	[SerializeField]
	float _timerTrowing = 0.1f;
	[SerializeField]
	float _timerjumping = 0.25f;
	[SerializeField]
	float _timerAttacking = 0.5f;
	[SerializeField]
	float _timerhurting = 0.1f;
	[SerializeField]
	float _timerlanded = 0.1f;


	public EnemyAnimation _EnemyAnimation;


	float timeridle;
	float timerwalking;
	float timerTrowing;
	float timerjumping;
	float timerAttacking;
	float timerhurting;
	float timerlanded;


	[SerializeField]
	GameObject player;
	// Use this for initialization
	void Start () {
		player= GameObject.Find("Player");

		timeridle = _timeridle;
		timerwalking = _timerwalking;
		timerTrowing = _timerTrowing;
		timerjumping = _timerjumping;
		timerAttacking = _timerAttacking;
		timerhurting = _timerhurting;
		timerlanded = _timerlanded;

		_EnemyCurrentState = Enemystate.Idle;
	}
	
	// Update is called once per frame
	void Update () {
		x = gameObject.transform.position.x;
		y = gameObject.transform.position.y;

		targetx = player.transform.position.x;
		targety = player.transform.position.y;

		switch (_EnemyCurrentState)
		{
			case Enemystate.Idle:
				if (_timeridle < 0)
				{
					//idle
					_EnemyAnimation.PlayIdle();
					_timeridle = timeridle;
				}
				else
				{
					_timeridle -= Time.deltaTime;
				}
				break;
			case Enemystate.Walking:
				if (_timerwalking < 0)
				{
					//walking
					_EnemyAnimation.PlayWalking();
					_timerwalking = timerwalking;

				}
				else
				{
					_timerwalking -= Time.deltaTime;
				}
				break;
			case Enemystate.Atacking:

				break;
			case Enemystate.Hit:

				break;
			case Enemystate.Jumping:
				if (_timerjumping < 0)
				{
					_EnemyAnimation.PlayJump();
					_timerjumping = timerjumping;
				}
				else
				{
					_timerjumping -= Time.deltaTime;
				}
				break;
		}




		if (flip)
		{

			gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
		}
		else if (!flip)
		{

			gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
		}

		if (x >= targetx + 0.5f && targetx >= x + lookingfield * -1)//link
		{

			_EnemyCurrentState = Enemystate.Walking;
			flip = false;
			//print("hallo");
		}
		else if (x <= targetx - 0.5f && targetx <= x + lookingfield)//rechts
		{
			//print("hallo 2");
			_EnemyCurrentState = Enemystate.Walking;
			flip = true;
		}
		else
		{
			_EnemyCurrentState = Enemystate.Idle;
		}

		if (y < targetx)
		{
			//_EnemyCurrentState = Enemystate.Jumping;
		}



		

		//print(flip);
	}
}
