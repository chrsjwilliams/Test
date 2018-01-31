using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    //Score score;
	// Use this for initialization
	void Start () {
        //score = GameObject.Find("GameManager").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        //score.score++;
        Score.score++;
    }
}
