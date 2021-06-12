using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack_Red : MonoBehaviour
{
    public Transform attackpoint;
    public float attackrange = 2;
    public LayerMask enemylayers;
    public Text BlueHP;
    public int v;


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
                v = int.Parse(BlueHP.text);
                v -= 10;
                if (v > 0) { BlueHP.text = v.ToString(); }
                else  BlueHP.text = "0";
               
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
