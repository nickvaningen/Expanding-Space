using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyStatemagine : MonoBehaviour {

	public enum Friendlystate { Walking, Idle, Atacking, Jumping, Hit, Null };
	Friendlystate _FriendlyCurrentState = Friendlystate.Null;

	private float targetx;
	private float x;
	public float speed = 5;
	public bool flip;
	private Vector2 H;

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


	public EnemyAnimation _FriendlyAnimation;


	float timeridle;
	float timerwalking;
	float timerTrowing;
	float timerjumping;
	float timerAttacking;
	float timerhurting;
	float timerlanded;

	// Use this for initialization
	void Start () {


		timeridle = _timeridle;
		timerwalking = _timerwalking;
		timerTrowing = _timerTrowing;
		timerjumping = _timerjumping;
		timerAttacking = _timerAttacking;
		timerhurting = _timerhurting;
		timerlanded = _timerlanded;

		_FriendlyCurrentState = Friendlystate.Idle;

	}
	
	// Update is called once per frame
	void Update () {

		switch (_FriendlyCurrentState)
		{
			case Friendlystate.Idle:
				if (_timeridle < 0)
				{
					//idle
					_FriendlyAnimation.PlayIdle();
					_timeridle = timeridle;
				}
				else
				{
					_timeridle -= Time.deltaTime;
				}
				break;
			case Friendlystate.Walking:
				if (_timerwalking < 0)
				{
					//walking
					_FriendlyAnimation.PlayWalking();
					_timerwalking = timerwalking;

				}
				else
				{
					_timerwalking -= Time.deltaTime;
				}
				break;
			case Friendlystate.Atacking:

				break;
			case Friendlystate.Hit:

				break;
			case Friendlystate.Jumping:

				break;
		}

		targetx = GameObject.Find("Player").transform.position.x;
		x = transform.position.x;

		if (x >= targetx - 3f || x <= targetx - 4f)//link
		{
			_FriendlyCurrentState = Friendlystate.Walking;

		}
		else
		{
			_FriendlyCurrentState = Friendlystate.Idle;
		}


		
	}
}
