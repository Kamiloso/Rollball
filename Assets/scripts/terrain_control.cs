using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrain_control : MonoBehaviour {

public Transform podazanie;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = podazanie.position + (new Vector3(0,10f,-18f));
	}
}
