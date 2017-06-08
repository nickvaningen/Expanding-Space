using UnityEngine;

public class PlayerInput : MonoBehaviour {
	public bool _wait = false;
	Rigidbody2D _rigidbody;
	public float _timer1 = 1;
	public float _timer2 = 1;
	public float _timer3 = 1;
	public float _timer4 = 1;
	public float _timer5 = 1;
	public bool flip;
	public Anamation _palyerAnimation;
	
	public Shooting _playerShoot;

	public int animationindex = 0;

	void Start()
	{
		_rigidbody = GetComponent<Rigidbody2D>();


	}


	// Update is called once per frame
	void Update () {

		
		if (gameObject.transform.position.y < -20) {
			//loses health
		}

		if (flip)
		{
			//print("hallo!");
			gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
		}
		else if (!flip)
		{
			//print("hallo?");
			gameObject.transform.rotation = Quaternion.Euler(0,0,0);
		}


		if (Input.GetAxis("Horizontal") > 0 && _wait == false)
		{
			//doe voorwaards
			_rigidbody.AddForce(transform.right * 15);
			flip = false;
		}
		else if (Input.GetAxis("Horizontal") < 0 && _wait == false)
		{
			_rigidbody.AddForce(transform.right * 15);
			//doe achterwaards
			flip = true;
		}
		else
		{
		}

		if (Input.GetAxis("Vertical") > 0 && _wait == false)
		{
			//doe jumping
			_rigidbody.AddForce(transform.up * 500);
			_wait = true;
			

		}
		else if (Input.GetAxis("Vertical") < 0)
		{
			
			//doe bukken

		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//print("fucking normal fags");
		if (other.gameObject.tag == "Ground"|| other.gameObject.tag == "enemy") {
			
			_wait = false;
		}
	}
}
