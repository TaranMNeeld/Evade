using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour {

	private Vector2 screenBounds;

	private float objectWidth;

	private float objectHeight;

	private void Start()
	{
		Camera main = Camera.main;
		float x = Screen.width;
		float y = Screen.height;
		Vector3 position = Camera.main.transform.position;
		screenBounds = main.ScreenToWorldPoint(new Vector3(x, y, position.z));
		Vector3 size = base.transform.GetComponent<SpriteRenderer>().bounds.size;
		objectWidth = size.x / 2f;
		Vector3 size2 = base.transform.GetComponent<SpriteRenderer>().bounds.size;
		objectHeight = size2.y / 2f;
	}

	private void Update()
	{
		Vector3 position = base.transform.position;
		position.x = Mathf.Clamp(position.x, screenBounds.x + objectWidth, screenBounds.x * -1f - objectWidth);
		position.y = Mathf.Clamp(position.y, screenBounds.y + objectHeight, screenBounds.y * -1f - objectHeight);
		base.transform.position = position;
	}
}
