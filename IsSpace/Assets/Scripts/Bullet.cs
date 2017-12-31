using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;

	void FixedUpdate(){
		transform.Translate(new Vector3(speed * Time.fixedDeltaTime, 0,0));
}	}
