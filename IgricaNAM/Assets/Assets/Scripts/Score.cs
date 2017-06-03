using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {


	public Text scoreText;
	public int kostValue;
	private int score;
	

	// Use this for initialization
	void Start () {

		score = 0;
		updateScore();

		
	}

	public void UpdateSc()
	{
		score -= 4;
		updateScore();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Otrov")
			UpdateSc();
		else
		{
			score += kostValue;
			updateScore();
		}
	}
	void updateScore()
	{
		scoreText.text = "Score: " + score.ToString();
	}

}
