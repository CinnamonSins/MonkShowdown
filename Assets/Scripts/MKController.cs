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
	public string recentkeystroke;
	public bool Collided = false;
	public string mostrecinp;
	private void OnTriggerStay2D(Collider2D other){
       Debug.Log("Blue Got Hit");
	   Collided = true;
    }
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
		if(Collided){
			if(mostrecinp=="w"){
				position.y = position.y - vertmove;
				Collided=false;
			}
			if(mostrecinp=="a"){
				position.x = position.x + horimove;
				Collided=false;
			}
			if(mostrecinp=="s"){
				position.y = position.y + vertmove;
				Collided=false;
			}
			if(mostrecinp=="d"){
				position.x = position.x - horimove;
				Collided=false;
			}
			if(mostrecinp=="up"){
				Collided=false;
			}
			if(mostrecinp=="left"){
				Collided=false;
			}
			if(mostrecinp=="down"){
				Collided=false;
			}
			if(mostrecinp=="right"){
				Collided=false;
			}
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			spriteRenderer.sprite = spriteArray[2];
			mostrecinp ="w";
			spriteRenderer.enabled =false;
			position.y = position.y + vertmove;	
			spriteRenderer.enabled =true;

		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			spriteRenderer.sprite = spriteArray[1];
			mostrecinp ="a";		
			spriteRenderer.enabled =false;	
			position.x = position.x - horimove;
			spriteRenderer.enabled =true;
			
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			spriteRenderer.sprite = spriteArray[0];
			mostrecinp ="s";
			spriteRenderer.enabled =false;
			position.y = position.y - vertmove;
			spriteRenderer.enabled =true;
			
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			spriteRenderer.sprite = spriteArray[3];
			mostrecinp ="d";
			spriteRenderer.enabled =false;
			position.x = position.x + horimove;
			spriteRenderer.enabled =true;
			
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			mostrecinp ="up";
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			mostrecinp ="left";	
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			mostrecinp ="down";
			
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			mostrecinp ="right";
		}
		transform.position = position;
    }
}
