using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreBehaviour : MonoBehaviour {

	public static float highscore;
	private static Text highscoreText;

	void Start () {
		highscoreText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update(){
		highscoreText.text = "Highscore: " + highscore;
	}
}
