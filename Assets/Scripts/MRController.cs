﻿using System.Collections;
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


	// Update is called once per frame
	void Update()
	{
		Vector2 position = transform.position;
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			spriteRenderer.sprite = spriteArray[2];
			position.y = position.y + 1;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			spriteRenderer.sprite = spriteArray[1];
			position.x = position.x - 1;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			spriteRenderer.sprite = spriteArray[0];
			position.y = position.y - 1;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			spriteRenderer.sprite = spriteArray[3];
			position.x = position.x + 1;
		}
		transform.position = position;
	}
}
