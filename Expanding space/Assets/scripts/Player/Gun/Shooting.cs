using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

	public AudioClip shootingsound;
	private AudioSource source;
	private float vollowRange = .5f;
	private float volhighRange = 1.0f;
	private float volhighScale = 1.0f;
	Vector2 _GunOffset;


	public GameObject projectile;
	public GameObject Player;

	public float shootingSpeed;

	// Use this for initialization
	void Awake()
	{
		source = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	public void Shoot()
	{
		_GunOffset = transform.position;
		//_GunOffset.x += 0.5f;
		_GunOffset.y += 0.1f;
		GameObject throwThis = Instantiate(projectile, _GunOffset, transform.rotation) as GameObject;
		throwThis.GetComponent<Rigidbody2D>().AddForce(transform.right * shootingSpeed);


		if (Player.GetComponent<PlayerInput_reloaded>().flip)
		{
			//_GunOffset.x += 2f;
			throwThis.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-shootingSpeed, 0));
			
		}
		else if (!Player.GetComponent<PlayerInput_reloaded>().flip)
		{
			//_GunOffset.x += 1f;
			throwThis.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(shootingSpeed, 0));
		}
		//throwThis.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-shootingSpeed,0));
		source.PlayOneShot(shootingsound, volhighScale);
	}
}
