using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {
	public Image vidaUI;
	public float vida = 100;
	public Vector3 spawn = new Vector3 (0, 0, -43);

	// Update is called once per frame
	void Update () {
		vidaUI.fillAmount = vida/100;
		if (vida <= 0 || transform.position.y < -10f) {
			vida = 100;
			gameObject.transform.position = spawn;
		}
	}
}
