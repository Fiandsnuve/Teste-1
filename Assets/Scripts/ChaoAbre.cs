using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoAbre : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		Destroy(gameObject);
	}
}
