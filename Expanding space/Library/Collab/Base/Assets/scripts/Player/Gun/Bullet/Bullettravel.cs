using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullettravel : MonoBehaviour {

    private float timer = 0.5f;
    public GameObject gameManger;
    public GUIText scoreText;
    public int scoreValue = 100;
    private int currentScore;
    public Text ScoreText;

    // Use this for initialization
    void Start()
    {
        currentScore = 0;
    }
    private void HandleScore()
    {
        print("yolo");
        ScoreText.text = "Score: " + currentScore;
    }
    // Update is called once per frame
    void Update () {
       
        timer -= Time.deltaTime;

        

        if (timer < 0)
        {
            Destroy(gameObject);
        }
	}

    

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "enemy")
        {
            //TextEditorScore.score += scoreValue;
            col.gameObject.GetComponent<hitpoints>().hit();
            currentScore += scoreValue;
            Destroy(this.gameObject);
            HandleScore();
        }
    }
}
