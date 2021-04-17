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
	   Collided = true;
    }
	IEnumerator ShowAndHide(SpriteRenderer spriteRenderer, float delay)
    {
        spriteRenderer.enabled =false;
        yield return new WaitForSeconds(delay);
        spriteRenderer.enabled =true;
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
			if(mostrecinp=="w"){
				Collided=false;
			}
			if(mostrecinp=="a"){
				Collided=false;
			}
			if(mostrecinp=="s"){
				Collided=false;
			}
			if(mostrecinp=="d"){
				Collided=false;
			}
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			spriteRenderer.sprite = spriteArray[2];
			mostrecinp ="up";
			StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));
			position.y = position.y + vertmove;	

		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			spriteRenderer.sprite = spriteArray[1];
			mostrecinp ="left";		
			StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));	
			position.x = position.x - horimove;
			
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			spriteRenderer.sprite = spriteArray[0];
			mostrecinp ="down";
			StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));
			position.y = position.y - vertmove;
			
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			spriteRenderer.sprite = spriteArray[3];
			mostrecinp ="right";
			StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));
			position.x = position.x + horimove;
			
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			mostrecinp ="w";
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			mostrecinp ="a";	
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			mostrecinp ="s";
			
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			mostrecinp ="d"; 	
		}
		transform.position = position;
	}
}
