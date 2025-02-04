using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_control : MonoBehaviour {

	bool klawisz1,klawisz2,klawisz3,klawisz4;

	// Update is called once per frame
	void Update ()
	{
		
		Rigidbody obrot = transform.GetComponent<Rigidbody>();

//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.W))
		{
			Debug.Log("Wcisnieto");
			klawisz1=true;
		}
		if(Input.GetKeyUp(KeyCode.W))
		{
			Debug.Log("Opuszczono");
			klawisz1=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("Wcisnieto2");
			klawisz2=true;
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			Debug.Log("Opuszczono2");
			klawisz2=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.S))
		{
			Debug.Log("Wcisnieto3");
			klawisz3=true;
		}
		if(Input.GetKeyUp(KeyCode.S))
		{
			Debug.Log("Opuszczono3");
			klawisz3=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.D))
		{
			Debug.Log("Wcisnieto4");
			klawisz4=true;
		}
		if(Input.GetKeyUp(KeyCode.D))
		{
			Debug.Log("Opuszczono4");
			klawisz4=false;
		}
//--------------------------------------------------
		
		//poruszanie sie

		if(klawisz1==true)
		{
			obrot.AddTorque(-Vector3.left*10);
		}
		if(klawisz2==true)
		{
			obrot.AddTorque(Vector3.forward*10);
		}
		if(klawisz3==true)
		{
			obrot.AddTorque(Vector3.left*10);
		}
		if(klawisz4==true)
		{
			obrot.AddTorque(-Vector3.forward*10);
		}
	}
}
