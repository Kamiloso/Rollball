using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_platform : MonoBehaviour {

	public Transform spadanie;
	int licznik;
	bool aktywowany=false;

	// Use this for initialization
	void Start ()
	{
		;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(aktywowany==true) licznik++;
		if(licznik==4)
		{
			transform.position = spadanie.position + (new Vector3(0f,-100f,0f));
			licznik=0;
		}	
	}

	void OnTriggerExit(Collider collision)
	{
		if((collision.gameObject.name=="Sphere")||(collision.gameObject.name=="left_sphere_prefab"))
		aktywowany=true;
	}
}
