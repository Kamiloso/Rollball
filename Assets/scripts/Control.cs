using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
	public bool is_left = false;
	bool klawisz1, klawisz2, klawisz3, klawisz4;

	private void RightInput()
	{
        // UP
        if (Input.GetKeyDown(KeyCode.UpArrow))
            klawisz1 = true;
        if (Input.GetKeyUp(KeyCode.UpArrow))
            klawisz1 = false;

        // LEFT
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            klawisz2 = true;
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            klawisz2 = false;

        // DOWN
        if (Input.GetKeyDown(KeyCode.DownArrow))
            klawisz3 = true;
        if (Input.GetKeyUp(KeyCode.DownArrow))
            klawisz3 = false;

        // RIGHT
        if (Input.GetKeyDown(KeyCode.RightArrow))
            klawisz4 = true;
        if (Input.GetKeyUp(KeyCode.RightArrow))
            klawisz4 = false;

        // RESET
        if (Input.GetKeyDown(KeyCode.R))
        {
            string levelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelName);
            return;
        }

        // MAIN MENU
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("main_menu");
            return;
        }
    }

	private void LeftInput()
	{
        // UP
        if (Input.GetKeyDown(KeyCode.W))
            klawisz1 = true;
        if (Input.GetKeyUp(KeyCode.W))
            klawisz1 = false;

        // LEFT
        if (Input.GetKeyDown(KeyCode.A))
            klawisz2 = true;
        if (Input.GetKeyUp(KeyCode.A))
            klawisz2 = false;

        // DOWN
        if (Input.GetKeyDown(KeyCode.S))
            klawisz3 = true;
        if (Input.GetKeyUp(KeyCode.S))
            klawisz3 = false;

        // RIGHT
        if (Input.GetKeyDown(KeyCode.D))
            klawisz4 = true;
        if (Input.GetKeyUp(KeyCode.D))
            klawisz4 = false;
    }
	
	// Update is called once per frame
	private void Update ()
	{
		if(!is_left)
            RightInput();
        else
            LeftInput();
	}

    private void FixedUpdate()
    {
        Rigidbody obrot = transform.GetComponent<Rigidbody>();

        if (klawisz1 == true)
        {
            obrot.AddTorque(-Vector3.left * 13);
        }
        if (klawisz2 == true)
        {
            obrot.AddTorque(Vector3.forward * 13);
        }
        if (klawisz3 == true)
        {
            obrot.AddTorque(Vector3.left * 13);
        }
        if (klawisz4 == true)
        {
            obrot.AddTorque(-Vector3.forward * 13);
        }
    }

    private void Start()
    {
        if(!is_left)
        {
            AudioSource[] AllOnScene = FindObjectsOfType<AudioSource>();
            foreach(AudioSource OnScene in AllOnScene)
            {
                if (OnScene.GetComponent<Transform>().name == "start2")
                    OnScene.volume *= 0.6f;
            }
        }
    }
}
