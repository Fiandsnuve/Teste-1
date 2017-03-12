using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinhos : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		if(other.gameObject.GetComponent<Vida>() != null)
		{
			other.gameObject.GetComponent<Vida> ().vida -= 1;
            #if UNITY_ANDROID
            Handheld.Vibrate();
            #endif
        }
    }
}
