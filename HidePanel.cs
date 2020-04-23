using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidePanel : MonoBehaviour {

	private Image image;

	private void Start() {
		image = GetComponent<Image>();
		Color color = image.color;
		color.a = 0f;
		image.color = color;
	}
}
