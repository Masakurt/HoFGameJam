using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {

	// Use this for initialization
	public static Options option;
	public float musicVolume = 0.5f;
	public float SFXVolume = 0.5f;
	public int numFIsh = 1;
	void Start () {
	if (option == null) {
			option = this;
			DontDestroyOnLoad (this);
		} else
			DestroyImmediate (gameObject);
	}
	
	// Update is called once per frame
	public void UpdateMusicVolume(float _volume){
		if (_volume < 0 || _volume > 1)
			return;
		else 
			musicVolume = _volume;
	}
	public void UpdateSFXVolume(float _volume){
		if (_volume < 0 || _volume > 1)
			return;
		else 
			SFXVolume = _volume;
	}
}
