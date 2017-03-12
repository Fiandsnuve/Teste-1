using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.GetComponent<Vida> () != null) {
			other.gameObject.GetComponent<Vida> ().vida = 0;
        }
	}
}
