using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayArea : MonoBehaviour {

	RectTransform playArea;
	Rigidbody2D rigid2D;
	RespawnCoin1 respawnCoin1;
	Laser1 laser1;
	Laser2 laser2;

	public static float width;
	public static float height;
	public static float maxX;
	public static float maxY;
	public static float xPos;
	public static float yPos;


	public static void setCoin1Bounds() {
		RespawnCoin1.respawnCoin (maxX, maxY, xPos, yPos);
	}
	public static void setLaser1Bounds() {
		Laser1.respawnLaser (maxX, maxY, xPos, yPos);
	}
	public static void setLaser2Bounds() {
		Laser2.respawnLaser (maxX, maxY, xPos, yPos);
	}

	// Use this for initialization
	void Start () {
		playArea = GetComponent<RectTransform> ();
		rigid2D = GetComponent<Rigidbody2D> ();
		respawnCoin1 = GetComponent<RespawnCoin1> ();
		laser1 = GetComponent<Laser1> ();
		laser2 = GetComponent<Laser2> ();
		width = playArea.rect.width;
		height = playArea.rect.height;
		maxX = width / 2;
		maxY = height / 2;
		xPos = playArea.rect.x;
		yPos = playArea.rect.y;
	}
}
