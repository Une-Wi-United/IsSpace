using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SetPos : MonoBehaviour
{
    public Transform globject;
	void Update (){transform.position.Set(globject.position.x, globject.position.y, transform.position.z);
}   }
