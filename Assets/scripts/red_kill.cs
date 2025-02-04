using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class red_kill : MonoBehaviour
{
	void OnTriggerEnter(Collider collision)
	{
		if((collision.gameObject.name=="Sphere")||(collision.gameObject.name=="left_sphere_prefab"))
		{
			Debug.Log("zginieto");
			string levelName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(levelName);
		}
	}
}
