using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MRController : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public Sprite newSprite;
	public Sprite[] spriteArray;
	public bool Collided = false;
	public string mostrecinp;
	private void OnTriggerStay2D(Collider2D other){
       Debug.Log("Red Got Hit");
	   Collided = true;
    }
	void Start()
	{
		spriteRenderer.sprite = newSprite;
		spriteRenderer.sprite = spriteArray[0];
	}

	public static float vertmove = 2.7F;
	public static float horimove = 1.25F;

	void Update()
	{	Vector2 position = transform.position;
		if(Collided){
			if(mostrecinp=="up"){
				position.y = position.y - vertmove;
				Collided=false;
			}
			if(mostrecinp=="left"){
				position.x = position.x + horimove;
				Collided=false;
			}
			if(mostrecinp=="down"){
				position.y = position.y + vertmove;
				Collided=false;
			}
			if(mostrecinp=="right"){
				position.x = position.x - horimove;
				Collided=false;
			}
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			spriteRenderer.sprite = spriteArray[2];
			mostrecinp ="up";
			spriteRenderer.enabled =false;
			position.y = position.y + vertmove;	
			spriteRenderer.enabled =true;

		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			spriteRenderer.sprite = spriteArray[1];
			mostrecinp ="left";		
			spriteRenderer.enabled =false;	
			position.x = position.x - horimove;
			spriteRenderer.enabled =true;
			
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			spriteRenderer.sprite = spriteArray[0];
			mostrecinp ="down";
			spriteRenderer.enabled =false;
			position.y = position.y - vertmove;
			spriteRenderer.enabled =true;
			
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			spriteRenderer.sprite = spriteArray[3];
			mostrecinp ="right";
			spriteRenderer.enabled =false;
			position.x = position.x + horimove;
			spriteRenderer.enabled =true;
			
		}
		transform.position = position;
	}
}
