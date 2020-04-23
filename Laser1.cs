using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser1 : MonoBehaviour {

	public static float moveSpeed;

	private static Vector2 location;

	private static RectTransform laser1;

	private Rigidbody2D rb2d;

	private FindPlayArea findPlayArea;

	private ScoreBehaviour scoreBehaviour;

	private SpriteShop spShop;

	public static float spawnPointX;

	public static float spawnPointY;

	public static float endPoint;

	public static void respawnLaser(float maxX, float maxY, float xPos, float yPos)
	{
		endPoint = maxX * 2f + laser1.rect.width * 100f;
		spawnPointX = xPos + maxX - laser1.rect.width * 100f;
		spawnPointY = Random.Range(0f, maxY * 2f);
		location.x = spawnPointX;
		location.y = spawnPointY;
	}

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		laser1 = GetComponent<RectTransform>();
		scoreBehaviour = GetComponent<ScoreBehaviour>();
		spShop = GetComponent<SpriteShop>();
		findPlayArea = GetComponent<FindPlayArea>();
		location = base.transform.position;
		FindPlayArea.setLaser1Bounds();
	}

	private void Update()
	{
		moveSpeed = SpriteShop.enemySpeed / 100f;
		if (location.x >= endPoint)
		{
			FindPlayArea.setLaser1Bounds();
		}
		location.x += moveSpeed;
		base.transform.position = location;
	}
}
