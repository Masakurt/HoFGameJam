using UnityEngine;
using System.Collections;

public class Menu_Buttons_Script : MonoBehaviour {

	// Use this for initialization
	public string levelToLoad;
	public void Activate ()	{
		Application.LoadLevel(levelToLoad);
	}
	public void Quit(){
		Application.Quit ();
	}
}
