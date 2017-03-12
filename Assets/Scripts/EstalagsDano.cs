using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstalagsDano : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if(other.gameObject.GetComponent<Vida>() != null)
		{
			other.gameObject.GetComponent<Vida> ().vida -= 20;
		}
	}

}
