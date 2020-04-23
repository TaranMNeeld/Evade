using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerData : MonoBehaviour {

	// Use this for initialization
	private void Start () {
		HighscoreBehaviour.highscore = PlayerPrefs.GetFloat("highscore", HighscoreBehaviour.highscore);
		CoinManager.sprites = PlayerPrefs.GetFloat("sprites", CoinManager.sprites);
	}
	
	// Update is called once per frame
	private void Update () {
		
	}
}
