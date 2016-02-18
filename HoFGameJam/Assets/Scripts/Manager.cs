using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {


	public void UpdateMusicVolume(float _volume){
		Options.option.UpdateMusicVolume (_volume);
	}
	public void UpdateSFXVolume(float _volume){
		Options.option.UpdateMusicVolume (_volume);
	}
}
