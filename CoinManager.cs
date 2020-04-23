using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour {

	public static float sprites; //Sprites are the currency
	private static Text spriteText;

	void Start () {
		spriteText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		spriteText.text = "Sprites: " + sprites;
	}
}
