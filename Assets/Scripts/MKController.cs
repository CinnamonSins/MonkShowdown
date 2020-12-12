using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class MKController : MonoBehaviour
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
	if (Input.GetKeyDown(KeyCode.W))
	{
	spriteRenderer.sprite = spriteArray[2];
	position.y = position.y + 1;
	}
	if (Input.GetKeyDown(KeyCode.A))
	{
			spriteRenderer.sprite = spriteArray[1];
			position.x = position.x - 1;
	}
	if (Input.GetKeyDown(KeyCode.S))
	{
			spriteRenderer.sprite = spriteArray[0];
			position.y = position.y - 1;
	}
	if (Input.GetKeyDown(KeyCode.D))
	{
			spriteRenderer.sprite = spriteArray[3];
			position.x = position.x + 1;
	}
        transform.position = position;
    }
}
