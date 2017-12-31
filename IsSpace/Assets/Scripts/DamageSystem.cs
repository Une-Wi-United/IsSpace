using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour{
    public float damage;
    public string [] targets;

    private void OnCollisionEnter2D(Collision2D other){
        for (int i = 0; i < targets.Length; i++){
            if (other.gameObject.tag == targets[i]){
                other.gameObject.GetComponent<HealSystem>().hp -= damage;
                Destroy(gameObject);
                break;
}   }   }   }
