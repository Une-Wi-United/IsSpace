using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    private Rigidbody2D RB2D;
    public float rotate = 0;
    public float speed = 0;
    public float maxspeed;
    public bool isRotated;
    public bool isMoved;

    public string[] keyboard;
    

	// Use this for initialization
	void Start ()
    {
        RB2D = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rotate > 360 || rotate < -360) rotate = 0;
        if (isRotated)
        {
            if (Input.GetKey(keyboard[0]))
            {
                rotate += 1;
            }
            if (Input.GetKey(keyboard[1]))
            {
                rotate -= 1;
            }
        }
        if (isMoved)
            {
            if (Input.GetKey(keyboard[2]) && speed < maxspeed){
                speed += 0.1f * Time.fixedDeltaTime;
            }
            if (Input.GetKey(keyboard[3]) && speed > -maxspeed){
                speed -= 0.1f * Time.fixedDeltaTime;
            }
            if (Input.GetKey("space")){
                if(speed > 0)
                speed -= speed /10;
            }
        }
        RB2D.MoveRotation(rotate);
        transform.Translate(new Vector3(speed * Time.fixedDeltaTime, 0,0));
    }
}
