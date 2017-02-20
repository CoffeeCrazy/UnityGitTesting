using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lol : MonoBehaviour {

	void Start () {
		gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(0, 180), 0);
	}
	
	void FixedUpdate () {
	    gameObject.transform.Rotate(0,4,0);
	}
}
