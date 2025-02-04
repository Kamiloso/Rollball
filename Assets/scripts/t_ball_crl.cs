using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class t_ball_crl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	bool klawisz1a,klawisz2a,klawisz3a,klawisz4a;
	// Update is called once per frame
	void Update () {

		Rigidbody obrot = transform.GetComponent<Rigidbody>();

//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("Wcisnieto");
			klawisz1a=true;
		}
		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			Debug.Log("Opuszczono");
			klawisz1a=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			Debug.Log("Wcisnieto2");
			klawisz2a=true;
		}
		if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			Debug.Log("Opuszczono2");
			klawisz2a=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			Debug.Log("Wcisnieto3");
			klawisz3a=true;
		}
		if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			Debug.Log("Opuszczono3");
			klawisz3a=false;
		}
//--------------------------------------------------
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			Debug.Log("Wcisnieto4");
			klawisz4a=true;
		}
		if(Input.GetKeyUp(KeyCode.RightArrow))
		{
			Debug.Log("Opuszczono4");
			klawisz4a=false;
		}
//--------------------------------------------------

//poruszanie sie

		if(klawisz1a==true)
		{
			obrot.AddTorque(-Vector3.left*100);
		}
		if(klawisz2a==true)
		{
			obrot.AddTorque(Vector3.forward*100);
		}
		if(klawisz3a==true)
		{
			obrot.AddTorque(Vector3.left*100);
		}
		if(klawisz4a==true)
		{
			obrot.AddTorque(-Vector3.forward*100);
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
