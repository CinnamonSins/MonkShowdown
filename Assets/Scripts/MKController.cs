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
	public static int movesleft = 7;
	private void OnTriggerStay2D(Collider2D other){
	   Collided = true;
    }
	IEnumerator ShowAndHide(SpriteRenderer spriteRenderer, float delay)
    {
        spriteRenderer.enabled =false;
        yield return new WaitForSeconds(delay);
        spriteRenderer.enabled =true;
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
		if(movesleft == 0){
			MRController.redturn = true;
			movesleft = 7;
        }
		if (MRController.redturn==false) {
			if (Collided)
			{
				if (mostrecinp == "w")
				{
					position.y = position.y - vertmove;
					Collided = false;
					movesleft += 1;
				}
				if (mostrecinp == "a")
				{
					position.x = position.x + horimove;
					Collided = false;
					movesleft += 1;
				}
				if (mostrecinp == "s")
				{
					position.y = position.y + vertmove;
					Collided = false;
					movesleft += 1;
				}
				if (mostrecinp == "d")
				{
					position.x = position.x - horimove;
					Collided = false;
					movesleft += 1;
				}
				if (mostrecinp == "w")
				{
					Collided = false;
				}
				if (mostrecinp == "a")
				{
					Collided = false;
				}
				if (mostrecinp == "s")
				{
					Collided = false;
				}
				if (mostrecinp == "d")
				{
					Collided = false;
				}
			}
			if (Input.GetKeyDown(KeyCode.W))
			{
				spriteRenderer.sprite = spriteArray[2];
				mostrecinp = "w";
				StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));
				position.y = position.y + vertmove;
				movesleft -= 1;

			}
			if (Input.GetKeyDown(KeyCode.A))
			{
				spriteRenderer.sprite = spriteArray[1];
				mostrecinp = "a";
				StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));
				position.x = position.x - horimove;
				movesleft -= 1;
			}
			if (Input.GetKeyDown(KeyCode.S))
			{
				spriteRenderer.sprite = spriteArray[0];
				mostrecinp = "s";
				StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));
				position.y = position.y - vertmove;
				movesleft -= 1;

			}
			if (Input.GetKeyDown(KeyCode.D))
			{
				spriteRenderer.sprite = spriteArray[3];
				mostrecinp = "d";
				StartCoroutine(ShowAndHide(spriteRenderer, 0.027f));
				position.x = position.x + horimove;
				movesleft -= 1;

			}
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				mostrecinp = "up";
			}
			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				mostrecinp = "left";
			}
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				mostrecinp = "down";

			}
			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				mostrecinp = "right";
			}
			transform.position = position;


		}
		
    }
}
