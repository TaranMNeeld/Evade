using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpriteShop : MonoBehaviour {

	public static float sprites;
	public static float enemySpeed = 250f;

	CoinManager coinManager;

	//Upgrade Variables
	static float buyPrice;
	Player player;

	public void loadShopScene() {
		SceneManager.LoadScene ("SpriteShop");
		PlayerPrefs.GetFloat("sprites", CoinManager.sprites);
		PlayerPrefs.GetFloat("moveSpeed", Player.moveSpeed);
		PlayerPrefs.GetFloat("enemySpeed", enemySpeed);
	}

	public void increasePlayerSpeed() {
		buyPrice = 200f;
		if (CoinManager.sprites >= buyPrice) {
			if (Player.moveSpeed < 200f) {
				Player.moveSpeed += 2f;
				CoinManager.sprites -= buyPrice;
				PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
				PlayerPrefs.SetFloat("moveSpeed", Player.moveSpeed);
			} else {
				Debug.Log ("Max Level");
			}
		}
	}
	public void decreaseEnemySpeed() {
		buyPrice = 300f;
		if (CoinManager.sprites >= buyPrice) {
			if (enemySpeed > 200f) {
				enemySpeed -= 2f;
				CoinManager.sprites -= buyPrice;
				PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
				PlayerPrefs.SetFloat("enemySpeed", enemySpeed);
			} else {
				enemySpeed = 200f;
				PlayerPrefs.SetFloat("enemySpeed", enemySpeed);
				Debug.Log ("Max Level");
			}
		}
	}

	// Use this for initialization
	void Start () {
		coinManager = GetComponent<CoinManager> ();
		player = GetComponent<Player> ();
		PlayerPrefs.SetFloat("sprites", 0);
		PlayerPrefs.SetFloat("moveSpeed", 150f);
		PlayerPrefs.SetFloat("enemySpeed", 250f);
	}
	
	// Update is called once per frame
	void Update () {
		sprites = CoinManager.sprites;
		Player.moveSpeed = PlayerPrefs.GetFloat("moveSpeed", Player.moveSpeed);
		enemySpeed = PlayerPrefs.GetFloat("enemySpeed", enemySpeed);
	}
}
