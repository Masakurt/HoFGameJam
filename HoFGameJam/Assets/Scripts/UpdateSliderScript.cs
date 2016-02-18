using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateSliderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Options.option) {
			if (gameObject.name == "Music_Slider") {
				GetComponent<Slider> ().value = Options.option.musicVolume;
			} else if (gameObject.name == "SFX_Slider") {
				GetComponent<Slider> ().value = Options.option.SFXVolume;
			}
		}
	}
}
