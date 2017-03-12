using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esmagar : MonoBehaviour {
	
	public GameObject[] esmagadores;
	protected BoxCollider box;
	protected float[] positionX;
	protected bool esmagando = false;

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.GetComponent<Vida> () != null) {
			other.gameObject.GetComponent<Vida> ().vida = 0;
		}
	}

	void Start (){
		box = gameObject.GetComponent<BoxCollider> ();
		positionX = new float[esmagadores.Length];
		for (int i=0;i<esmagadores.Length;i++) {
			positionX [i] = esmagadores[i].transform.position.x;
		}
	}

	// Update is called once per frame
	void Update () {
		if (esmagando) {
			for (int i = 0; i < esmagadores.Length; i++) {
				if (positionX [i] >= 0) {
					esmagadores [i].transform.position = new Vector3 (esmagadores [i].transform.position.x - 0.1f, esmagadores [i].transform.position.y, esmagadores [i].transform.position.z);
				} else if (positionX [i] < 0) {
					esmagadores [i].transform.position = new Vector3 (esmagadores [i].transform.position.x + 0.1f, esmagadores [i].transform.position.y, esmagadores [i].transform.position.z);
				}
			}
			if (positionX [0] > 0 && esmagadores [0].transform.position.x <= 4 || positionX [0] < 0 && esmagadores [0].transform.position.x >= -4) {
				box.enabled = true;
			}
			if (positionX [0] > 0 && esmagadores [0].transform.position.x <= 3 || positionX [0] < 0 && esmagadores [0].transform.position.x >= -3) {
				esmagando = false;
				box.enabled = false;
			}
		} else {
			for (int i=0;i<esmagadores.Length;i++) {
				if (positionX [i] >= 0) {
					esmagadores [i].transform.position = new Vector3 (esmagadores[i].transform.position.x + 0.1f , esmagadores[i].transform.position.y , esmagadores[i].transform.position.z);
				}else if (positionX [i] < 0) {
					esmagadores [i].transform.position = new Vector3 (esmagadores[i].transform.position.x - 0.1f , esmagadores[i].transform.position.y , esmagadores[i].transform.position.z);
				}
			}
			if (positionX [0] > 0 && esmagadores[0].transform.position.x >= positionX[0] || positionX[0] < 0 && esmagadores[0].transform.position.x <= positionX[0]) {
				esmagando = true;
			}
		}
	}
}
