using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour {

    public float speed;
    public float damage;
    public string owner;

    void FixedUpdate ()
    {
        transform.Translate(new Vector3(speed * Time.fixedDeltaTime,0));
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag) {
            case "Asteroid": {
                    Destroy(other.gameObject);
                    Destroy(gameObject);

                    break;
            }

        }
    }
}
