using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public string shotCase;
    public float maxTimeReload=10;
    public float timeReload = 0;
    public GameObject bullet;

    void FixedUpdate(){
        if (Input.GetKey(shotCase)){
            if (timeReload <= 0f){
                Instantiate(bullet, transform.position, transform.rotation);
				timeReload = maxTimeReload;
        }   }
        if (timeReload > 0) {timeReload -= Time.fixedDeltaTime;
}   }   }
