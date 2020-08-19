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
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        Vector2 position = transform.position;
        position.x = position.x + 3f * horizontal*Time.deltaTime;
        position.y = position.y + 3f * vertical*Time.deltaTime    ;
        transform.position = position;
    }
}
