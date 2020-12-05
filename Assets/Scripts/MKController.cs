using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MKController : MonoBehaviour
{
    // Start is called before the first frame update,
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
	if (Input.GetKeyDown(KeyCode.W))
	{
	position.y = position.y + 1;
	}
	if (Input.GetKeyDown(KeyCode.A))
	{
	position.x = position.x - 1;
	}
	if (Input.GetKeyDown(KeyCode.S))
	{
	position.y = position.y - 1;
	}
	if (Input.GetKeyDown(KeyCode.D))
	{
	position.x = position.x + 1;
	}
        transform.position = position;
    }
}
