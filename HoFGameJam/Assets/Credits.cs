using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	// Use this for initialization
	public float speed = 1;
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown("escape")) {
			Application.LoadLevel("Options_Menu");
		}
		Vector3 temp = GetComponent<RectTransform> ().position;
		temp.y += speed * Time.deltaTime;
		GetComponent<RectTransform> ().position = temp;
	}
}
