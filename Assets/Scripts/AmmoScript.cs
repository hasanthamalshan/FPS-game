using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour {

	public AudioSource AmmoCollectsound;
	private void OnTriggerEnter() {
		ammoCollect.ammo += 5;
		AmmoCollectsound.Play();
		Destroy(gameObject);

	}
}
