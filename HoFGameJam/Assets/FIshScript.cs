using UnityEngine;
using System.Collections;

public class FIshScript : MonoBehaviour {

	// Use this for initialization
	public uint myIndex = 0;
	Quaternion myrotation;
	void Awake () {
		myrotation = transform.rotation;
		for (int i = 0;;i++) {
			Vector3 temp;
			temp.x = Random.Range (-19, 19);
			float yrange = Mathf.Sqrt (361 - temp.x * temp.x);
			temp.y = Random.Range (-yrange, yrange);
			temp.z = Mathf.Sqrt (361 - temp.x * temp.x - temp.y * temp.y) + -10;
			transform.position = temp;
			bool tempBool = GeometryUtility.TestPlanesAABB (GeometryUtility.CalculateFrustumPlanes (Camera.main), GetComponent<Collider> ().bounds);
			if (!tempBool) {
				break;
			}
		}
		if (Options.option) {
			AudioSource[] tempAS = GetComponents<AudioSource> (); 
			foreach (AudioSource item in tempAS) {
				item.volume = Options.option.SFXVolume;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation (-Camera.main.transform.forward, Camera.main.transform.up);
		Quaternion temp = transform.rotation;
		temp.x += myrotation.x;
		temp.y += myrotation.y;
		temp.z += myrotation.z;
		transform.rotation = temp;
	}
	void OnDestroy(){
		Camera.main.GetComponent<Reset> ().ChangeSound (myIndex);
	}
}
