using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telepot : MonoBehaviour {

	public Transform pozycja;
	public Vector3 pozycja_wymagana;
	public bool dodaj_pozycje;

	void OnTriggerEnter(Collider collision)
	{
		if(collision.gameObject.name=="Sphere")
		{
			Debug.Log("teleportowano");
			
			if(dodaj_pozycje==false) pozycja.position = pozycja_wymagana;
			else pozycja.position = pozycja.position + pozycja_wymagana;
		}
	}
}
