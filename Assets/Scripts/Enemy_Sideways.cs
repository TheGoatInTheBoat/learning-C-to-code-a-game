using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Sideways : MonoBehaviour
{

    [SerializeField] private float dmg;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player"){
            collision.GetComponent<Health>().TakeDamage(dmg);
        }
    }
    
}