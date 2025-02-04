using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class complete : MonoBehaviour
{
	public int aktualny_level;
	public string skieruj_gdzie_indziej = "";
	string levele;
	int levele_int;
	void OnTriggerEnter(Collider collision)
	{
		if((collision.gameObject.name=="Sphere")||(collision.gameObject.name=="Physics_sphere_this"))
		{
			Debug.Log("ukonczono poziom");
			//te do leveli i wczytywanie, zapis itd.

				//-wczytanie
			try
			{
				using (StreamReader streamR = new StreamReader("Rollball_Data/levels.txt"))
				{
					levele = streamR.ReadLine();
					levele_int = int.Parse(levele);
				}
			}
			catch (System.Exception)
			{
				throw;
			}
				//-porownanie
			if(aktualny_level > levele_int)
			{
				using (StreamWriter streamW = new StreamWriter("Rollball_Data/levels.txt",false))
				{
					streamW.WriteLine(aktualny_level);
				}
			}

			//SceneManager.LoadScene("win_screen");
			if (skieruj_gdzie_indziej == "")
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			else
				SceneManager.LoadScene(skieruj_gdzie_indziej);
		}
	}
}
