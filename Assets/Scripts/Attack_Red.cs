using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Red : MonoBehaviour
{   
    public Transform attackpoint;
    public float attackrange =2;
    public LayerMask enemylayers;


    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        attackpoint.position = position;
        Debug.Log("before if");
        if (Input.GetKeyDown(KeyCode.M))
        {   
            Debug.Log("you are attacking.");
            Collider2D[] hitenemies =Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemylayers);
            Debug.Log(hitenemies);
            foreach(Collider2D enemy in hitenemies){
                Debug.Log("We hit "+enemy.name);
            }
            Debug.Log("after foreach;");
        }   
        Debug.Log("After if");
    }
    void OnDrawGizmosSelected()
    {   
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }   
}
