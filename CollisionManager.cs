using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour {

	ScoreBehaviour scoreBehaviour;
	HighscoreBehaviour highscoreBehaviour;
	FindPlayArea findPlayArea;
	Player player;

	public AudioClip spriteCollect;
	private AudioSource source;

	RespawnCoin1 respawnCoin1;

	CoinManager coins;

	public void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Coin1") {
			FindPlayArea.setCoin1Bounds();
			ScoreBehaviour.score += 200f;
			CoinManager.sprites += 1000;
			//source.PlayOneShot(spriteCollect, 1f);
			RespawnCoin1.coinActive = false;
		} else if (col.gameObject.tag == "Laser") {
			Player.gameOver = true;
		} else {
			Player.gameOver = false;
		}
	}

	// Use this for initialization
	void Start () {
		scoreBehaviour = GetComponent<ScoreBehaviour> ();
		highscoreBehaviour = GetComponent<HighscoreBehaviour> ();
		findPlayArea = GetComponent<FindPlayArea> ();
		player = GetComponent<Player> ();
		respawnCoin1 = GetComponent<RespawnCoin1> ();
		coins = GetComponent<CoinManager> ();
		//source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
