using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float deltaRotate=0;
    public float rotate = 0;
    public float speed = 0;
    public float deltaSpeed = 0;
    public float maxspeed;
    public bool isRotated;
    public bool isMoved;
    public string[] keyboard;

    void FixedUpdate(){
            if (rotate > 360 || rotate < -360) { rotate = 0;}
            if (isRotated){
                if (Input.GetKey(keyboard[0])) { rotate += deltaRotate; }
                if (Input.GetKey(keyboard[1])){rotate -= deltaRotate;
            }   }
            if (isMoved){
                if (Input.GetKey(keyboard[2]) && speed < maxspeed){speed += deltaSpeed * Time.fixedDeltaTime;}
           else if (Input.GetKey(keyboard[3]) && speed > -maxspeed){ speed -= deltaSpeed * Time.fixedDeltaTime/3;}
           else {if (speed > 0) { speed -= speed / 10; }
            }   }                          
            transform.rotation = Quaternion.Euler(0, 0, rotate);
            transform.Translate(new Vector3(speed * Time.fixedDeltaTime, 0,0));
}   }
