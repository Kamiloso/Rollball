using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class run_control : MonoBehaviour {

	bool klawisz2,klawisz4;
	public Vector3 speed;

	// Update is called once per frame
	void Update ()
	{	
		Rigidbody obrot = transform.GetComponent<Rigidbody>();
		speed.x=obrot.velocity.x;
		speed.y=obrot.velocity.y;
		obrot.velocity = speed;

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

		if((klawisz2==true)&&(obrot.velocity.x > -4f))
		{
			obrot.velocity += new Vector3(-0.5f,0,0) * Time.deltaTime * 50f;
			//obrot.AddTorque(Vector3.forward*10);
		}
		if((klawisz4==true)&&(obrot.velocity.x < 4f))
		{
			obrot.velocity += new Vector3(0.5f,0,0) * Time.deltaTime * 50f;
			//obrot.AddTorque(-Vector3.forward*10);
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
