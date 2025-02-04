using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall_kill : MonoBehaviour
{
	int rand;
	void Update()
	{
		if(transform.position.y<-5)
		{
			rand = Random.Range(1, 50);
			if(rand==2)
			{
				//SceneManager.LoadScene("level_secret");
			}
			else
			{
				Debug.Log(rand);
				string levelName = SceneManager.GetActiveScene().name;
				SceneManager.LoadScene(levelName);
			}
		}
	}
}
