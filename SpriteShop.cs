using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteShop : MonoBehaviour
{
	public static float sprites;

	public static float enemySpeed = 250f;

	private CoinManager coinManager;

	private static float buyPrice;

	private Player player;

	private SkinManager skinManager;

	public void loadShopScene()
	{
		SceneManager.LoadScene("SpriteShop");
		PlayerPrefs.GetFloat("sprites", CoinManager.sprites);
		PlayerPrefs.GetFloat("moveSpeed", Player.moveSpeed);
		PlayerPrefs.GetFloat("enemySpeed", enemySpeed);
	}

	public void increasePlayerSpeed()
	{
		buyPrice = 200f;
		if (CoinManager.sprites >= buyPrice)
		{
			if (Player.moveSpeed < 200f)
			{
				Player.moveSpeed += 1f;
				CoinManager.sprites -= buyPrice;
				PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
				PlayerPrefs.SetFloat("moveSpeed", Player.moveSpeed);
			}
			else
			{
				Debug.Log("Max Level");
			}
		}
	}

	public void decreaseEnemySpeed()
	{
		buyPrice = 300f;
		if (CoinManager.sprites >= buyPrice)
		{
			if (enemySpeed > 200f)
			{
				enemySpeed -= 1f;
				CoinManager.sprites -= buyPrice;
				PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
				PlayerPrefs.SetFloat("enemySpeed", enemySpeed);
			}
			else if (enemySpeed < 200f)
			{
				enemySpeed = 200f;
			}
		}
	}

	private void Start()
	{
		coinManager = GetComponent<CoinManager>();
		player = GetComponent<Player>();
		skinManager = GetComponent<SkinManager>();
	}

	private void Update()
	{
		sprites = CoinManager.sprites;
		Player.moveSpeed = PlayerPrefs.GetFloat("moveSpeed", Player.moveSpeed);
		enemySpeed = PlayerPrefs.GetFloat("enemySpeed", enemySpeed);
		if (enemySpeed < 200f)
		{
			enemySpeed = 200f;
		}
	}
}