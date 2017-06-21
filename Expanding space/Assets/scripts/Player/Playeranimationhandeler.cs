using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeranimationhandeler : MonoBehaviour {

		public bool _wait = false;
		Rigidbody2D _rigidbody;
		public float _timer1 = 0.15f;
		public float _timer2 = 0.05f;
		public float _timer3 = 0.1f;
		public float _timer4 = 0.25f;
		public float _timer5 = 0.5f;
		public float _timer6 = 0;
		public float _timer7 = 0;
		private int counter = 0;
		public bool flip;
		public Anamation _palyerAnimation;

		public Shooting _playerShoot;

		enum States { IDLE, WALKING, SHOOTING, JUMPING, HURTING, LANDED };
		States currentState;

		

		void Start()
		{
		_wait = true;
		_timer6 += Time.deltaTime;
		_rigidbody = GetComponent<Rigidbody2D>();
		currentState = States.IDLE;
		_timer7 = 0f;
		}

		void Update()
		{

		if (flip)
		{
			gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
		}
		else if (!flip)
		{
			gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
		}


		if (Input.GetAxis("Horizontal") > 0 && _wait == false)
		{
			//doe voorwaards
			currentState = States.WALKING;
			flip = false;
			
		}
		else if (Input.GetAxis("Horizontal") < 0 && _wait == false)
		{

			//doe achterwaards
			currentState = States.WALKING;
			flip = true;
			
		}
		else if (currentState == States.WALKING)
		{
			currentState = States.IDLE;
		}


		if (Input.GetAxis("Vertical") > 0 && _wait == false)
		{
			//doe jumping
			_palyerAnimation.index = 1;
			currentState = States.JUMPING;
			_wait = true;


		}
		else if (Input.GetAxis("Vertical") < 0)
		{

			//doe bukken

		}


		if (_timer5 < 0)
		{
			if (Input.GetAxis("Fire1") == 1 && _wait == false)
			{
				//schieten
				_palyerAnimation.index = 1;
				currentState = States.SHOOTING;
				_timer5 = 0.5f;
			}
		}
		else
		{
			_timer5 -= Time.deltaTime;
		}


		switch (currentState) {
			case States.LANDED:
				_wait = true;
				if (_timer7 < 0)
				{
					_palyerAnimation.PlayLanded();
					counter++;
					_timer7 = 0.1f;
				}
				else
				{
					_timer7 -= Time.deltaTime;
				}

				if (counter > 2)
				{
					currentState = States.IDLE;
					counter = 0;
					_wait = false;
				}
				break;

			case States.HURTING:
				_wait = true;
				if (_timer7 < 0) {
					_palyerAnimation.Playbeinghit();
					counter++;
					_timer7 = 0.1f;
				}
				else {
					_timer7 -= Time.deltaTime;
				}

				if (counter > 2)
				{
					currentState = States.IDLE;
					counter = 0;
					_wait = false;
				}
				/*if (_timer4 < 0)
				{
					currentState = States.IDLE;
				}
				else
				{
					//currentState = States.IDLE;
					_timer4 -= Time.deltaTime;
				}*/
				break;

			case States.IDLE:
					if (_timer1 < 0)
					{
					_palyerAnimation.Playidle();
					_timer1 = 0.5f;
					}
					else
					{
					_timer1-= Time.deltaTime;
					}
				break;

				case States.WALKING:
					if (_timer2 < 0)
					{
					_palyerAnimation.Playwalking();
					_timer2 = 0.05f;
					}
					else
					{
					_timer2 -= Time.deltaTime;
					}
				break;

				case States.JUMPING:
					if (_timer2 < 0)
					{
					_palyerAnimation.Playjumping();

					_timer2 = 0.2f;
					}
					else
					{
					_timer2 -= Time.deltaTime;
					}
				break;

			case States.SHOOTING:
				if (_palyerAnimation.index == 5)
					{
					currentState = States.IDLE;
					//_palyerAnimation.index = 1;
					}
				if (_timer3 < 0)
					{
					_palyerAnimation.Playshooting();
					if (_palyerAnimation.index == 4)
					{
						_playerShoot.Shoot();
					} 
					_timer3 = 0.07f;
					}
					else
					{
					_timer3 -= Time.deltaTime;
					}
				break;

			}
		print(currentState);
		//print(_palyerAnimation.index);
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		//print("fucking normal fags");
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "enemy")
		{
			if (currentState == States.JUMPING)
			{
				currentState = States.LANDED;
				_timer7 = 0f;

			}
			_wait = false;
		}
	}
}
