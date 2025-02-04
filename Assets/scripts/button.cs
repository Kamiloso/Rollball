using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {
	
	string levele;
	int levele_int;
	public Button startButton0002;
	public Button startButton0003;
	public Button startButton0004;
	public Button startButton0005;
	public Button startButton0006;
	public Button startButton0007;
	public Button startButton0008;
	public Button startButton0009;
	public Button startButton0010;
	public Button startButton0011;
	public Button startButton0012;
	public Button startButton0013;
	public Button startButton0014;
	public Button startButton0015;
	public Button startButton0016;
	public Button startButton0017;
	public Button startButton0018;
	public Button startButton0019;
	public Button startButton0020;
	public Button startButton0021;
	public Button startButton0022;
	public Button startButton0023;
	public Button startButton0024;
	public Button startButton0025;
	public Button startButton0026;
	public Button startButton0027;
	public Button startButton0028;
	public Button startButton0029;
	public Button startButton0030;
	public Button startButton0031;
	public Button startButton0032;

	public Button startButton_end;
	public Button startButton_run;
	public Button startButton_mtp1;
	// Use this for initialization
	void Start ()
	{
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
			using (StreamWriter streamW = new StreamWriter("Rollball_Data/levels.txt",false))
			{
				streamW.WriteLine("1");
			}	
			throw;
		}
		//ustawienie
		if(levele_int == 0)
		{
			SceneManager.LoadScene("level1");
		}
		if(levele_int >= 2)
		{
			startButton0002.interactable = true;
		}
		if(levele_int >= 3)
		{
			startButton0003.interactable = true;
		}	
		if(levele_int >= 4)
		{
			startButton0004.interactable = true;
		}	
		if(levele_int >= 5)
		{
			startButton0005.interactable = true;
		}	
		if(levele_int >= 6)
		{
			startButton0006.interactable = true;
		}	
		if(levele_int >= 7)
		{
			startButton0007.interactable = true;
		}	
		if(levele_int >= 8)
		{
			startButton0008.interactable = true;
		}	
		if(levele_int >= 9)
		{
			startButton0009.interactable = true;
			startButton_run.interactable = true;
		}	
		if(levele_int >= 10)
		{
			startButton0010.interactable = true;
		}	
		if(levele_int >= 11)
		{
			startButton0011.interactable = true;
		}
		if(levele_int >= 12)
		{
			startButton0012.interactable = true;
		}	
		if(levele_int >= 13)
		{
			startButton0013.interactable = true;
		}	
		if(levele_int >= 14)
		{
			startButton0014.interactable = true;
		}	
		if(levele_int >= 15)
		{
			startButton0015.interactable = true;
		}	
		if(levele_int >= 16)
		{
			startButton0016.interactable = true;
		}	
		if(levele_int >= 17)
		{
			startButton_mtp1.interactable = true;
			startButton0017.interactable = true;
		}	
		if(levele_int >= 18)
		{
			startButton0018.interactable = true;
		}	
		if(levele_int >= 19)
		{
			startButton0019.interactable = true;
		}	
		if(levele_int >= 20)
		{
			startButton0020.interactable = true;
		}	
		if(levele_int >= 21)
		{
			startButton0021.interactable = true;
		}	
		if(levele_int >= 22)
		{
			startButton0022.interactable = true;
		}	
		if(levele_int >= 23)
		{
			startButton0023.interactable = true;
		}	
		if(levele_int >= 24)
		{
			startButton0024.interactable = true;
		}
		if(levele_int >= 25)
		{
			startButton0025.interactable = true;
		}	
		if(levele_int >= 26)
		{
			startButton0026.interactable = true;
		}	
		if(levele_int >= 27)
		{
			startButton0027.interactable = true;
		}	
		if(levele_int >= 28)
		{
			startButton0028.interactable = true;
		}	
		if(levele_int >= 29)
		{
			startButton0029.interactable = true;
		}	
		if(levele_int >= 30)
		{
			startButton0030.interactable = true;
		}	
		if(levele_int >= 31)
		{
			startButton0031.interactable = true;
		}	
		if(levele_int >= 32)
		{
			startButton0032.interactable = true;
		}
		if(levele_int >= 33)
		{
			startButton_end.interactable = true;
		}			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
