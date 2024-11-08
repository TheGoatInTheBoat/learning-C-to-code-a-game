using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    [SerializeField] private float start_health;
    private Animator anim;
    public float current_health { get; set; }

    private void Awake(){
        current_health = start_health;
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float amount_dmg){
        current_health = Mathf.Clamp(current_health - amount_dmg, 0, start_health);
        if (current_health > 0){ // player is hurt
            anim.SetTrigger("hurt");
        }else{ // player is dead
            anim.SetTrigger("die");
        }
    }
    private void Update()
    {
        
    }
}
