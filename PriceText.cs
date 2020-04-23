using UnityEngine;
using UnityEngine.UI;

public class PriceText : MonoBehaviour
{
	public Text[] priceText;

	private SkinManager skin;

	private void Start()
	{
		skin = GetComponent<SkinManager>();
	}

	private void Update()
	{
		for (int i = 0; i < priceText.Length; i++)
		{
			if (SkinManager.isPurchased[i])
			{
				priceText[i].text = "Owned";
			}
			else if (!SkinManager.isPurchased[i])
			{
				priceText[i].text = "500 Sp";
			}
		}
	}
}