using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 30;
		Debug.DrawRay(transform.position, forward, Color.red);
	}
}
