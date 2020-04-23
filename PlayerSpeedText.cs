using UnityEngine;
using UnityEngine.UI;

public class PlayerSpeedText : MonoBehaviour
{
	private Text text1;

	private Player player;

	private void Start()
	{
		text1 = GetComponent<Text>();
		player = GetComponent<Player>();
	}

	private void Update()
	{
		text1.text = "Player Speed: " + PlayerPrefs.GetFloat("playerSpeed", Player.moveSpeed);
	}
}