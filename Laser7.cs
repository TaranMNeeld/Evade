using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser7 : MonoBehaviour {
private float moveSpeed;

	private static Vector2 location;

	private static RectTransform laser7;

	private Rigidbody2D rb2d;

	private FindPlayArea findPlayArea;

	private SpriteShop spShop;

	private ScoreBehaviour scoreBehaviour;

	private Player player;

	public static float spawnPointX;

	public static float spawnPointY;

	public static float endPoint;

	public static bool alive;

	public static void respawnLaser(float maxX, float maxY, float xPos, float yPos)
	{
		endPoint = maxX * 2f + laser7.rect.width * 100f;
		spawnPointX = xPos + maxX - laser7.rect.width * 100f;
		spawnPointY = Random.Range(0f, maxY * 2f);
		location.x = spawnPointX;
		location.y = spawnPointY;
	}

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		laser7 = GetComponent<RectTransform>();
		scoreBehaviour = GetComponent<ScoreBehaviour>();
		findPlayArea = GetComponent<FindPlayArea>();
		spShop = GetComponent<SpriteShop>();
		location = base.transform.position;
		FindPlayArea.setLaser7Bounds();
		player = GetComponent<Player>();
	}

	private void Update()
	{
		moveSpeed = SpriteShop.enemySpeed / 100f;
		if (ScoreBehaviour.score >= 9000f)
		{
			if (location.x >= endPoint)
			{
				FindPlayArea.setLaser7Bounds();
				return;
			}
			location.x += moveSpeed;
			base.transform.position = location;
		}
		else if (ScoreBehaviour.score < 9000f)
		{
			location.x = Random.Range(1000, 1000);
			location.y = Random.Range(1000, 1000);
			base.transform.position = location;
		}
	}
}
