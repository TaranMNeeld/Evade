using UnityEngine;

public class EquipSkin : MonoBehaviour
{
	public Sprite[] skinSprites;

	private SkinManager skinManager;

	private SpriteRenderer renderer;

	private void Start()
	{
		renderer = GetComponent<SpriteRenderer>();
		skinManager = GetComponent<SkinManager>();
	}

	private void Update()
	{
		if (SkinManager.equipped)
		{
			renderer.sprite = skinSprites[SkinManager.indexOfSprite];
		}
	}
}