using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public string shotCase;

    public float maxTimeReload=2;
    public float timeReload = 0;
    public GameObject bullet;
    private GameObject tempBullet;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(shotCase))
        {
            if (timeReload < 1)
            {
                tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
                tempBullet.GetComponent<Bullet>().owner=gameObject.name;
                timeReload = maxTimeReload;
            }

        }
        if (timeReload > 0) timeReload -= Time.deltaTime;
    }
}
