using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic_platform : MonoBehaviour {

	public Transform spadanie;
	int licznik;
	bool aktywowany=false, urzyty=false;
	public Vector3 dystans;
	public int powtorzenia;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 20;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(aktywowany==true) licznik++;
		if((licznik>0)&&(urzyty==false))
		{
			transform.position = spadanie.position + dystans;
		}
		if(licznik==powtorzenia)
		{
			urzyty = true;
		}	
	}

	void OnTriggerEnter(Collider collision)
	{
		if((collision.gameObject.name=="Sphere")||(collision.gameObject.name=="left_sphere_prefab"))
		aktywowany=true;
	}
}
