using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class Manager : MonoBehaviour {
    private int currentScore;
    public Text scoreText;
    // Use this for initialization
    void Start()
    {
        //currentScore = 0;

    }

    private void HandleScore()
    {
        //scoreText.text = "Score: " + currentScore;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.tag == "")
        {
            //currentScore++;
            //HandleScore();
        }
    }

}