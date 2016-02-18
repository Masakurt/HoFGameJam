using UnityEngine;
using System.Collections;

public class FIshScript : MonoBehaviour {

	// Use this for initialization
	public uint myIndex = 0;
	void Start () {
		for (;;) {
			Vector3 temp;
			temp.x = Random.Range (-19, 19);
			float yrange = Mathf.Sqrt (361 - temp.x * temp.x);
			temp.y = Random.Range (-yrange, yrange);
			temp.z = Mathf.Sqrt (361 - temp.x * temp.x - temp.y * temp.y) + -10;
			transform.position = temp;
			if (!(GeometryUtility.TestPlanesAABB (GeometryUtility.CalculateFrustumPlanes (Camera.main), GetComponent<Collider> ().bounds))) {
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnDestroy(){
		GameObject.Find ("Main Camera").GetComponent<Reset> ().ChangeSound (myIndex);
		//BroadcastMessage ("ChangeSound", myIndex);
	}
}
