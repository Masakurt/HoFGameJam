using UnityEngine;
using System.Collections;

public class Image : MonoBehaviour {

	// Use this for initialization
	public Canvas myCanvas;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<RectTransform> ().sizeDelta = myCanvas.GetComponent<RectTransform> ().sizeDelta;
	}
}
