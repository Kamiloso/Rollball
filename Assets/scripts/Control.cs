using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
	bool klawisz1,klawisz2,klawisz3,klawisz4;
	
	// Update is called once per frame
	void Update ()
	{
		
		Rigidbody obrot = transform.GetComponent<Rigidbody>();

//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("Wcisnieto");
			klawisz1=true;
		}
		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			Debug.Log("Opuszczono");
			klawisz1=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			Debug.Log("Wcisnieto2");
			klawisz2=true;
		}
		if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			Debug.Log("Opuszczono2");
			klawisz2=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			Debug.Log("Wcisnieto3");
			klawisz3=true;
		}
		if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			Debug.Log("Opuszczono3");
			klawisz3=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			Debug.Log("Wcisnieto4");
			klawisz4=true;
		}
		if(Input.GetKeyUp(KeyCode.RightArrow))
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

		//pojedyncze

		if(Input.GetKeyDown(KeyCode.R))
		{
			Debug.Log("Zrestartowano");
			string levelName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(levelName);
		}

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Debug.Log("Cofnieto do menu");
			SceneManager.LoadScene("main_menu");
		}
	}
}
