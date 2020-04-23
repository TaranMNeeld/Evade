using System;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
	public Sprite[] skinSprites;

	public static bool[] isPurchased;

	public static bool[] isEquipped;

	private SpriteRenderer spriteRenderer;

	private CoinManager coin;

	private Player player;

	private float skinPrice;

	public static int indexOfSprite;

	public static int indexOfIsPurchased;

	public static int indexOfIsEquipped;

	public static bool equipped;

	private void Start()
	{
		coin = GetComponent<CoinManager>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		coin = GetComponent<CoinManager>();
		isEquipped = new bool[skinSprites.Length];
		isPurchased = new bool[skinSprites.Length];
		for (int i = 0; i < isPurchased.Length; i++)
		{
			isEquipped[i] = (PlayerPrefs.GetInt("isEquipped" + i) != 0);
			isPurchased[i] = (PlayerPrefs.GetInt("isPurchased" + i) != 0);
		}
		isPurchased[0] = true;
		isEquipped[0] = true;
	}

	public void buySkin()
	{
		indexOfSprite = Array.IndexOf(skinSprites, spriteRenderer.sprite);
		skinPrice = 500f;
		if (!isPurchased[indexOfSprite] && CoinManager.sprites >= skinPrice)
		{
			isPurchased[indexOfSprite] = true;
			CoinManager.sprites -= skinPrice;
			PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
		}
		else
		{
			Debug.Log("You already own this skin.");
		}
		for (int i = 0; i < isPurchased.Length; i++)
		{
			PlayerPrefs.SetInt("isEquipped" + i, isEquipped[i] ? 1 : 0);
			PlayerPrefs.SetInt("isPurchased" + i, isPurchased[i] ? 1 : 0);
		}
	}

	public void equipSkin()
	{
		indexOfSprite = Array.IndexOf(skinSprites, spriteRenderer.sprite);
		Debug.Log("Start----Index: " + indexOfSprite + "/isPurchased = " + isPurchased[indexOfSprite]);
		Debug.Log("Index: " + indexOfSprite + "/isEquipped = " + isEquipped[indexOfSprite]);
		if (isPurchased[indexOfSprite])
		{
			isEquipped[indexOfSprite] = true;
			for (int i = 0; i < isEquipped.Length; i++)
			{
				if (i != indexOfSprite)
				{
					isEquipped[i] = false;
				}
			}
		}
		else
		{
			Debug.Log("You don't own this skin.");
		}
		for (int j = 0; j < isEquipped.Length; j++)
		{
			Debug.Log("Index: " + j + " = " + isPurchased[j]);
		}
		Debug.Log("END----Index: " + indexOfSprite + "/isPurchased = " + isPurchased[indexOfSprite]);
		Debug.Log("Index: " + indexOfSprite + "/isEquipped = " + isEquipped[indexOfSprite]);
		for (int k = 0; k < isPurchased.Length; k++)
		{
			PlayerPrefs.SetInt("isEquipped" + k, isEquipped[k] ? 1 : 0);
			PlayerPrefs.SetInt("isPurchased" + k, isPurchased[k] ? 1 : 0);
		}
	}

	private void Update()
	{
		if (isEquipped[indexOfSprite] && isPurchased[indexOfSprite])
		{
			equipped = true;
		}
		else
		{
			equipped = false;
		}
	}
}