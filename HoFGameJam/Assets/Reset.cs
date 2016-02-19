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
	public Arrowscript arrow;
	bool played  =false;
	void Start () {
		if (Options.option) {
			for (int i = 0; i < sounds.Length; i++) {
				sounds [i].volume = Options.option.musicVolume;
			}
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
		if (Input.GetButtonDown("Fire1") && found) {
			found = false;
			int index = Random.Range(0, objects.Length);
			GetComponent<Controls>().enabled = true;
			DestroyImmediate(target);
			target = GameObject.Instantiate(objects[index]);
			if(arrow){
			arrow.ChangeTarget(target.transform);
				arrow.gameObject.SetActive(true);
			}
			played = false;
			if(Options.option){
				for (int i = 0; i < sounds.Length; i++) {
				sounds[i].volume = Options.option.musicVolume;
				}
			}
		}
		if (target) {
			if (GeometryUtility.TestPlanesAABB (GeometryUtility.CalculateFrustumPlanes (Camera.main), target.GetComponent<Collider> ().bounds)) {
				found = true;
				Quaternion rotation = Quaternion.LookRotation(target.transform.position - transform.position);
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
				GetComponent<Controls> ().enabled = false;
				if(arrow){
					arrow.gameObject.SetActive(false);
				}
				if(!played){
					target.GetComponent<AudioSource>().Play();
					played  =true;
					target.GetComponent<ParticleSystem>().Play();
					for (int i = 0; i < sounds.Length; i++) {
						sounds[i].volume = 0.25f;
					}
				}
			}
			else {
				found = false;
				if(arrow){
					arrow.ChangeTarget(target.transform);
					arrow.gameObject.SetActive(true);
				}
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
