using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCoin3 : MonoBehaviour {

		private static Rigidbody2D rb2d;

	private static RectTransform rectTrans;

	private static ScoreBehaviour scoreBehaviour;

	private FindPlayArea findPlayArea;

	private static float spawnPointX;

	private static float spawnPointY;

	private static Vector2 location;

	public static bool coinActive;

	public static void respawnCoin(float maxX, float maxY, float xPos, float yPos)
	{
		spawnPointX = Random.Range(rectTrans.rect.width * 100f, maxX * 2f - rectTrans.rect.width * 100f);
		spawnPointY = Random.Range(rectTrans.rect.width * 100f, maxY * 2f - rectTrans.rect.height * 100f);
		location.x = spawnPointX;
		location.y = spawnPointY;
		coinActive = true;
	}

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		rectTrans = GetComponent<RectTransform>();
		scoreBehaviour = GetComponent<ScoreBehaviour>();
		findPlayArea = GetComponent<FindPlayArea>();
		location = base.transform.position;
	}

	private void Update()
	{
		if (ScoreBehaviour.score >= 4000f)
		{
			if (!coinActive)
			{
				FindPlayArea.setCoin3Bounds();
			}
		}
		else if (ScoreBehaviour.score < 4000f)
		{
			location.x = Random.Range(1000, 1000);
			location.y = Random.Range(1000, 1000);
			coinActive = false;
		}
		base.transform.position = location;
	}
}