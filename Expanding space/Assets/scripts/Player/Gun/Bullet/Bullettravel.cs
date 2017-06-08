using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullettravel : MonoBehaviour {

    private float timer = 1f;
    public GameObject gameManger;
    public GUIText scoreText;
    public int scoreValue = 100;


    // Use this for initialization
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
       
        timer -= Time.deltaTime;

        

        if (timer < 0)
        {
            Destroy(gameObject);
        }
	}

    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "enemy(Clone)")
        {
            //TextEditorScore.score += scoreValue;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
