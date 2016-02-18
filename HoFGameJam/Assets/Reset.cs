using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	// Use this for initialization
	public GameObject[] objects;
	public string Name;
	public string Details;
	public GameObject target;
	public bool found = false;
	public AudioSource[] sounds;
	float SFXVolume = 0.5f;
	void Start () {
		if (Options.option) {
			for (int i = 0; i < sounds.Length; i++) {
				sounds [i].volume = Options.option.musicVolume;
			}
			SFXVolume = Options.option.SFXVolume;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown("Fire1") && found) {
			found = false;
			int index = Random.Range(0, objects.Length);
			DestroyImmediate(target);
			target = GameObject.Instantiate(objects[index]);
			GetComponent<Controls>().enabled = true;
		}
		if (target) {
			if (GeometryUtility.TestPlanesAABB (GeometryUtility.CalculateFrustumPlanes (Camera.main), target.GetComponent<Collider> ().bounds)) {
				found = true;				
				Quaternion rotation = Quaternion.LookRotation(target.transform.position - transform.position);
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
				GetComponent<Controls> ().enabled = false;
			}
			else {
				found = false;
			}
		}
		if (!found) {
			GetComponent<Controls>().enabled = true;
		}
	}
	public void ChangeSound(uint _index)	{
		if (_index > sounds.Length || _index == 0)
			return;
		for (int i = 1; i < sounds.Length; i++) {
			sounds[i].mute = true;
		}
		sounds [_index].mute = false;
	}
}
