using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SetPos : MonoBehaviour
{
    public Transform globject;
	void Update ()
    {
        transform.position = globject.position;
	}
}
