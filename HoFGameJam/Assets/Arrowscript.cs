using UnityEngine;
using System.Collections;

public class Arrowscript : MonoBehaviour {
    public Transform fish;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(fish);
    }
	public void ChangeTarget(Transform _newTarget)	{
		fish = _newTarget;
	}
}
