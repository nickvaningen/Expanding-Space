using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput_reloaded : MonoBehaviour {

		public bool _wait = false;
		Rigidbody2D _rigidbody;
		public float _timeridle = 0.15f;
		public float _timerwalking = 0.05f;
		public float _timershootinganimatie = 0.1f;
		public float _timerjumping = 0.25f;
		public float _timershooting = 0.5f;
		public float _timerhurting = 0;
		public float _timerlanded = 0;
		private int counter = 0;
		public bool flip;
		public Anamation _palyerAnimation;

        public AudioClip Jumpsound;
        public AudioClip WalkingSound;
        private AudioSource source;
        private float _VolSound = 1.0f;
        public float _VolDelay = 1.0f;


		public float moveSpeed = 0.5f;
		float moveSpeedCurrent = 0;
		public float moveSpeedDecfactor = 0.95f;
		public float moveSpeedMax = 10;
		public float jumpingforce;

	public GameObject platform;	

		float timeridle;
		float timerwalking;
		float timershootinganimatie;
		float timerjumping;
		float timershooting;
		float timerhurting;
		float timerlanded;

	//public GameObject platform;
		

		float xPrevious;
		float yPrevious;


		public Shooting _playerShoot;

		public enum States { IDLE, WALKING, SHOOTING, JUMPING, HURTING, LANDED };
		public States currentState;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        
    }
    
        
    

    void Start()
		{
		moveSpeedCurrent = moveSpeedCurrent / 100;
		moveSpeed = moveSpeed / 100;
		moveSpeedMax = moveSpeedMax / 100;
		//moveSpeedDecfactor = moveSpeedDecfactor / 100;



		timeridle = _timeridle;
		timerwalking = _timerwalking;
		timershootinganimatie = _timershootinganimatie;
		timerjumping = _timerjumping;
		timershooting = _timershooting;
		timerhurting = _timerhurting;
		timerlanded = _timerlanded;

		_wait = true;
		_rigidbody = GetComponent<Rigidbody2D>();
		currentState = States.IDLE;
		_timerlanded = 0f;

		
	}

		void Update()
		{
		xPrevious = transform.position.x;
		yPrevious = transform.position.y;


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
			moveSpeedCurrent += moveSpeed;

			if (moveSpeedCurrent >= moveSpeedMax)
			{
				moveSpeedCurrent = moveSpeedMax;
			}
			
			currentState = States.WALKING;
			flip = false;

		}
		else if (Input.GetAxis("Horizontal") < 0 && _wait == false)
		{

			//doe achterwaards
			moveSpeedCurrent -= moveSpeed;

			if (moveSpeedCurrent <= -moveSpeedMax)
			{
				moveSpeedCurrent = -moveSpeedMax;
			}
			currentState = States.WALKING;
			flip = true;

		}
		else if (currentState == States.WALKING)
		{
			currentState = States.IDLE;
		}
		else
		{
			moveSpeedCurrent *= moveSpeedDecfactor;
			
			if (moveSpeedCurrent >= -moveSpeed && moveSpeedCurrent <= moveSpeed)
			{
				//moveSpeedCurrent = 0;
			}
		}


		if (Input.GetAxis("Vertical") > 0 && _wait == false)
		{
			//doe jumping
			
			_palyerAnimation.index = 1;
			currentState = States.JUMPING;
			_wait = true;
            source.PlayDelayed(_VolDelay);


        }
		else if (Input.GetAxis("Vertical") < 0)
		{

			//doe bukken

		}


		if (_timershooting < 0)
		{
			if (Input.GetAxis("Fire1") == 1 && _wait == false)
			{
				//schieten
				
				_palyerAnimation.index = 1;
				currentState = States.SHOOTING;
				_timershooting = timershooting;
			}
		}
		else
		{
			_timershooting -= Time.deltaTime;
		}


		switch (currentState) {
			case States.LANDED:
				_wait = true;
				if (_timerlanded < 0)
				{
					_palyerAnimation.PlayLanded();
					counter++;
					_timerlanded = timerlanded;
				}
				else
				{
					_timerlanded -= Time.deltaTime;
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
				if (_timerhurting < 0) {
					_palyerAnimation.Playbeinghit();
					counter++;
					_timerhurting = timerhurting;
				}
				else {
					_timerhurting -= Time.deltaTime;
				}

				if (counter > 2)
				{
					currentState = States.IDLE;
					counter = 0;
					_wait = false;
				}
				break;

			case States.IDLE:
					if (_timeridle < 0)
					{
					_palyerAnimation.Playidle();
					_timeridle = timeridle;
					}
					else
					{
					_timeridle -= Time.deltaTime;
					}
				break;

				case States.WALKING:
					if (_timerwalking < 0)
					{
					_palyerAnimation.Playwalking();
					_timerwalking = timerwalking;
					}
					else
					{
					_timerwalking -= Time.deltaTime;
					}
				break;

				case States.JUMPING:
					if (_timerjumping < 0)
					{
					_palyerAnimation.Playjumping();

					_timerjumping = timerjumping;
					
					}
					else
					{
					_timerjumping -= Time.deltaTime;
					}

				if (_palyerAnimation.index == 3) {
					_rigidbody.AddForce(transform.up * jumpingforce);
					_rigidbody.AddForce(transform.right * (jumpingforce / 4));
                    
                    
				}
				break;

			case States.SHOOTING:
				if (_palyerAnimation.index == 5)
					{
					currentState = States.IDLE;
					//_palyerAnimation.index = 1;
					}
				if (_timershootinganimatie < 0)
					{
					_palyerAnimation.Playshooting();
					if (_palyerAnimation.index == 3)
					{
						_playerShoot.Shoot();
					}
					_timershootinganimatie = timershootinganimatie;
					}
					else
					{
					_timershootinganimatie -= Time.deltaTime;
					}
				break;

			}

		//print(moveSpeedCurrent);
		transform.position = new Vector3(xPrevious + moveSpeedCurrent, yPrevious, 0);
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		//print("fucking normal fags");
		if ((other.gameObject.tag == "Ground" || other.gameObject.tag == "enemy" || other.gameObject.tag == "friendly") && transform.position.y > other.transform.position.y)
		{
			if (currentState == States.JUMPING)
			{
				_timerlanded = 0f;
				currentState = States.LANDED;

			}
			_wait = false;
		}
		else
		{

		}
	}
}
