using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attack_mk : MonoBehaviour
{   
    public Transform attackpoint;
    public float attackrange =2;
    public LayerMask enemylayers;
    public Text RedHP;
    public int v;


    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        attackpoint.position = position;
        Debug.Log("before if statement.");
        if (Input.GetKeyDown(KeyCode.X))
        {   
            Debug.Log("you are attacking.");
            Collider2D[] hitenemies =Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemylayers);
            Debug.Log(hitenemies);
            foreach(Collider2D enemy in hitenemies){
                Debug.Log("We hit"+enemy.name);
                v = int.Parse(RedHP.text);
                v -= 10;
                if (v > 0) { RedHP.text = v.ToString(); }
                else RedHP.text = "0";
                

            }
            Debug.Log("after the foreach");

        }
        Debug.Log("After if");
    }
    void OnDrawGizmosSelected()
    {   
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }
}
