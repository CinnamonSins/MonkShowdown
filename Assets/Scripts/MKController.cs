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
	
	public static float vertmove = 2.7F;
	public static float horimove = 1.25F;
	// Update is called once per frame
	void Update()
    {
        Vector2 position = transform.position;
	if (Input.GetKeyDown(KeyCode.W))
	{
			spriteRenderer.sprite = spriteArray[2];
			position.y = position.y + vertmove;
	}
	if (Input.GetKeyDown(KeyCode.A))
	{
			spriteRenderer.sprite = spriteArray[1];
			position.x = position.x - horimove;
	}
	if (Input.GetKeyDown(KeyCode.S))
	{
			spriteRenderer.sprite = spriteArray[0];
			position.y = position.y - vertmove;
	}
	if (Input.GetKeyDown(KeyCode.D))
	{
			spriteRenderer.sprite = spriteArray[3];
			position.x = position.x + horimove;
		}
        transform.position = position;
    }
}
