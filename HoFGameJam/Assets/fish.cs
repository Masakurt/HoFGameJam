using UnityEngine;
using System.Collections;

public class fish : MonoBehaviour {
    uint timer;
	
	// Update is called once per frame
	void Update () {
        if (timer != 0) {
            ++timer;
            if (timer == 15000) {
                gameObject.SendMessage("Relocate");
                timer = 0;
            }
        }
	}

     void OnTriggerEnter(Collider other) {
        ++timer;
    }
}
