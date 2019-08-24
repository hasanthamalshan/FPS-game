using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour {

	private void OnTriggerEnter() {
		ammoCollect.ammo += 10;
		Destroy(gameObject);
	}
}
