﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser6 : MonoBehaviour {

private float moveSpeed;

	private static Vector2 location;

	private static RectTransform laser6;

	private Rigidbody2D rb2d;

	private FindPlayArea findPlayArea;

	private SpriteShop spShop;

	private Player player;

	public static float spawnPointX;

	public static float spawnPointY;

	public static float endPoint;

	public static bool alive;

	public static void respawnLaser(float maxX, float maxY, float xPos, float yPos)
	{
		endPoint = 0f - laser6.rect.height * 100f;
		spawnPointX = Random.Range(0f, maxX * 2f);
		spawnPointY = maxY * 2f + laser6.rect.height * 200f;
		location.x = spawnPointX;
		location.y = spawnPointY;
	}

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		laser6 = GetComponent<RectTransform>();
		findPlayArea = GetComponent<FindPlayArea>();
		spShop = GetComponent<SpriteShop>();
		location = base.transform.position;
		FindPlayArea.setLaser6Bounds();
		player = GetComponent<Player>();
	}

	private void Update()
	{
		moveSpeed = SpriteShop.enemySpeed / -100f;
		if (ScoreBehaviour.score >= 6500f)
		{
			if (location.y <= endPoint)
			{
				FindPlayArea.setLaser6Bounds();
				return;
			}
			location.y += moveSpeed;
			base.transform.position = location;
		}
		else if (ScoreBehaviour.score < 6500f)
		{
			location.x = Random.Range(1000, 1000);
			location.y = Random.Range(1000, 1000);
			base.transform.position = location;
		}
	}
}