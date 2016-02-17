using UnityEngine;
using System.Collections;

public class FIshScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 temp;
		temp.x = Random.Range (-20, 20);
		float yrange = Mathf.Sqrt (400 - temp.x * temp.x);
		temp.y = Random.Range (-yrange, yrange);
		temp.z = Mathf.Sqrt (400 - temp.x * temp.x - temp.y * temp.y) + -10;
		transform.position = temp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
