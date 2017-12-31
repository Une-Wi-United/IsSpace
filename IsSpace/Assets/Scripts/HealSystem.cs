using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSystem : MonoBehaviour
{
    public float maxhp;
    public float hp;

    void Start(){
        hp = maxhp;
    }

    void Update(){
        if (hp < 1){Destroy(gameObject);}
        else if (hp > maxhp){hp = maxhp;
}   }   }

