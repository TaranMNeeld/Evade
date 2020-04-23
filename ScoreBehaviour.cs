using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour {

	public static float score = 200f;
	public static float lastScore;
	
	private Text scoreText;
	private Player player;

	private void Start () {
		scoreText = GetComponent<Text> ();
		player = GetComponent<Player> ();
	}
	
	// Update is called once per frame
	private void Update(){
		scoreText.text = "Score: " + score;
		if (Player.gameOver == false) {
			score -= 1f;
		}
		if (score <= 0f) {
			// Player.gameOver = true;
		} else {
			Player.gameOver = false;
		}
	}

}
