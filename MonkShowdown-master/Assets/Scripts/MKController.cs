using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MKController : MonoBehaviour
{   
    // Start is called before the first frame update,
    void Start()
    {
        Vector2 position = transform.position;
        position.y = 482;
        position.x = 394;
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y = position.y + 96;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y = position.y - 96;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x = position.x + 96;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x = position.x - 96;
        }

        transform.position = position;
    }
}
