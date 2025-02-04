using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

	public Transform podazanie;
	public Transform left_podazanie;
	public bool multiplayer;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(multiplayer==false)
		transform.position = podazanie.position + (new Vector3(0,2f,-4.5f));

		else
		transform.position = (left_podazanie.position+podazanie.position)/2 + (new Vector3(0,2f,-4.5f));
	}
}
