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
	RespawnCoin2 respawnCoin2;
	RespawnCoin3 respawnCoin3;

	CoinManager coins;

	public void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Coin1") {
			FindPlayArea.setCoin1Bounds();
			ScoreBehaviour.score += 200f;
			CoinManager.sprites += 1000;
			//source.PlayOneShot(spriteCollect, 1f);
			RespawnCoin1.coinActive = false;
		} else if (col.gameObject.tag == "Coin2") {
			FindPlayArea.setCoin2Bounds ();
			ScoreBehaviour.score += 200f;
			CoinManager.sprites += 1;
			//source.PlayOneShot(spriteCollect, 1f);
			RespawnCoin2.coinActive = false;
		} else if (col.gameObject.tag == "Coin3") {
			FindPlayArea.setCoin3Bounds ();
			ScoreBehaviour.score += 200f;
			CoinManager.sprites += 1;
			//source.PlayOneShot(spriteCollect, 1f);
			RespawnCoin3.coinActive = false;
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
		respawnCoin2 = GetComponent<RespawnCoin2> ();
		respawnCoin3 = GetComponent<RespawnCoin3> ();
		coins = GetComponent<CoinManager> ();
		//source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
