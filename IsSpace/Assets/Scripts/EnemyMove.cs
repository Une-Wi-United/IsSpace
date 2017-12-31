using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMove : MonoBehaviour {
	public float startSmoothing;
	public float smoothing;
	public GameObject target;
	void Update () {
		transform.position = Vector3.LerpUnclamped(transform.position, target.transform.position, smoothing * Time.deltaTime);
}	}
