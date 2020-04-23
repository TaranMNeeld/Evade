using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser2 : MonoBehaviour {

		private float moveSpeed;

	private static Vector2 location;

	private static RectTransform laser2;

	private Rigidbody2D rb2d;

	private FindPlayArea findPlayArea;

	private SpriteShop spShop;

	public static float spawnPointX;

	public static float spawnPointY;

	public static float endPoint;

	private bool online;

	public static void respawnLaser(float maxX, float maxY, float xPos, float yPos)
	{
		endPoint = 0f - laser2.rect.height * 100f;
		spawnPointX = Random.Range(0f, maxX * 2f);
		spawnPointY = maxY * 2f + laser2.rect.height * 200f;
		location.x = spawnPointX;
		location.y = spawnPointY;
	}

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		laser2 = GetComponent<RectTransform>();
		findPlayArea = GetComponent<FindPlayArea>();
		spShop = GetComponent<SpriteShop>();
		location = base.transform.position;
		FindPlayArea.setLaser2Bounds();
	}

	private void Update()
	{
		moveSpeed = SpriteShop.enemySpeed / -100f;
		if (location.y <= endPoint)
		{
			FindPlayArea.setLaser2Bounds();
		}
		location.y += moveSpeed;
		base.transform.position = location;
	}
}
