using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_platform : MonoBehaviour {

	public Rigidbody jump;
	public Vector3 wybicie;
	public string dziala_na;
	int licznik;
	bool aktywowany;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider collision)
	{
		if(collision.gameObject.name==dziala_na)
		{
			aktywowany=true;
		}
	}

	void FixedUpdate ()
	{
		if(aktywowany==true) licznik++;
		if((aktywowany==true)&&(licznik>=5))
		{
			Debug.Log("Skoczono");
			jump.velocity = wybicie;
			aktywowany=false;
		}
	}
}
