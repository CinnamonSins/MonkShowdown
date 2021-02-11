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
		if (Input.GetKeyDown(KeyCode.W))
		{
			spriteRenderer.sprite = spriteArray[2];
			mostrecinp ="up";
			spriteRenderer.enabled =false;
			position.y = position.y + vertmove;	
			spriteRenderer.enabled =true;

		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			spriteRenderer.sprite = spriteArray[1];
			mostrecinp ="left";		
			spriteRenderer.enabled =false;	
			position.x = position.x - horimove;
			spriteRenderer.enabled =true;
			
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			spriteRenderer.sprite = spriteArray[0];
			mostrecinp ="down";
			spriteRenderer.enabled =false;
			position.y = position.y - vertmove;
			spriteRenderer.enabled =true;
			
		}
		if (Input.GetKeyDown(KeyCode.D))
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
