using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_hitpoint : MonoBehaviour {

	[SerializeField]
	public int health = 100;
	private int _damage = 100/3;
	public GameObject hartjes;
	[SerializeField]
	Sprite hartjes3;
	[SerializeField]
	Sprite hartjes2;
	[SerializeField]
	Sprite hartjes1;
	[SerializeField]
	float _Pushbackforce;
	private float timer = 0;
	public GameObject player;
	public GameObject Enemy;
    public LoadScenes dead;
    public int sceneIndex;
	[SerializeField]

	void Update () {
		if (health < 0)
		{
			Destroy(hartjes);
			//Debug.Log("dead");
			Destroy(this.gameObject);
            SceneManager.LoadScene(sceneIndex);
        }

		switch (health)
		{
			case 100:
				hartjes.GetComponent<UnityEngine.UI.Image>().sprite = hartjes3;
				break;
			case 67:
				hartjes.GetComponent<UnityEngine.UI.Image>().sprite = hartjes2;
				break;
			case 34:
				hartjes.GetComponent<UnityEngine.UI.Image>().sprite = hartjes1;
				break;
		}
		//print(health);
		
		
		if (timer > 0)
		{
			//timer -= Time.deltaTime;
		}
	}

	void OnCollisionStay2D (Collision2D other){
		if (timer <= 0)
		{
			if (other.gameObject.tag == "enemy" && player.GetComponent<PlayerInput_reloaded>().currentState != PlayerInput_reloaded.States.HURTING)
			{
				player.GetComponent<PlayerInput_reloaded>().currentState = PlayerInput_reloaded.States.HURTING;
				//print("hiya!");
				health -= _damage;
				player.GetComponent<Rigidbody2D>().AddForce(transform.right * _Pushbackforce);
				Enemy.GetComponent<Rigidbody2D>().AddForce(transform.right * _Pushbackforce);
				timer = 2f;
				

			}

		}
		else
		{
			timer -= Time.deltaTime;
		}

	}

	void OnCollisionExit2D(Collision2D other)
	{
		//timer = 0;
	}
}
