using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreStatText : MonoBehaviour {

    public Text playerSpeedText;
    public Text enemySpeedText;

    Player player;
    SpriteShop shop;

    void Start() {
        player = GetComponent<Player> ();
        shop = GetComponent<SpriteShop> ();
    }

    void Update() {
        playerSpeedText.text = "Player Speed: " + Player.moveSpeed;
        enemySpeedText.text = "Enemy Speed: " + SpriteShop.enemySpeed;
    }
}
