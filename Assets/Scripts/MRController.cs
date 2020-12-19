using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MRController : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public Sprite newSprite;
	public Sprite[] spriteArray;
	// Start is called before the first frame update,
	void Start()
	{
		spriteRenderer.sprite = newSprite;
		spriteRenderer.sprite = spriteArray[0];
	}

	public static float vertmove = 2.630529F;
	public static float horimove = 1.223702F;

	void Update()
	{
		Vector2 position = transform.position;
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			spriteRenderer.sprite = spriteArray[2];
			position.y = position.y + vertmove;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			spriteRenderer.sprite = spriteArray[1];
			position.x = position.x - horimove;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			spriteRenderer.sprite = spriteArray[0];
			position.y = position.y - vertmove;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			spriteRenderer.sprite = spriteArray[3];
			position.x = position.x + horimove;
		}
		transform.position = position;
	}
}
