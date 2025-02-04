using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_ball : MonoBehaviour {

	int licznik = 0;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		licznik++;
		if(licznik==10) gameObject.GetComponent<Renderer> ().enabled = true;
		if(licznik==20) gameObject.GetComponent<Renderer> ().enabled = false;
		if(licznik==25) gameObject.GetComponent<Renderer> ().enabled = true;
		if(licznik==30) gameObject.GetComponent<Renderer> ().enabled = false;
		if(licznik==35) gameObject.GetComponent<Renderer> ().enabled = true;
	}
}
