using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstalagsAtivador : MonoBehaviour {
	protected GameObject[] Estalags;
	public string tag;

	void OnTriggerEnter (Collider other) {
		this.GetComponent<BoxCollider> ().enabled = false;
		Estalags = GameObject.FindGameObjectsWithTag (tag);
		foreach (GameObject Estalag in Estalags) {
			Estalag.GetComponent<Rigidbody>().useGravity = true;
		}
	}
}
