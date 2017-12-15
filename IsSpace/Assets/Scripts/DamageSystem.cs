using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    public float maxhp=100;
    public float hp;
    public float defense;
    public float damage;

    void Update(){
        if (hp < 1){
            Destroy(gameObject);
        }
        else if (hp > maxhp){
            hp = maxhp;
        }
    }















}

