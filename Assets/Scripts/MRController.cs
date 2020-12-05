using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MRController : MonoBehaviour
{
	// Start is called before the first frame update,
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Vector2 position = transform.position;
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			position.y = position.y + 1;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			position.x = position.x - 1;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			position.y = position.y - 1;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			position.x = position.x + 1;
		}
		transform.position = position;
	}
}
