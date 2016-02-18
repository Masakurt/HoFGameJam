using UnityEngine;
using System.Collections;

public class Arrowscript : MonoBehaviour {
    public Transform fish;
    Vector3 heading;
    float dist;
    Vector3 scale;

	// Use this for initialization
	void Start () {
        scale = transform.localScale;
        
    }
	
	// Update is called once per frame
	void Update () {
        heading = Camera.main.transform.position - transform.position;
        dist = heading.magnitude;
        //dir = heading / dist;
        //Quaternion rot = new Quaternion(dir.x, dir.y, dir.z, 1);
        //transform.rotation = rot;
        transform.LookAt(fish);
        transform.localScale = scale / (dist/1.5f) * 10;
    }
}
