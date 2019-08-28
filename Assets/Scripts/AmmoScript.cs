using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour {

	[SerializeField] GameObject m9;
	

	public AudioSource AmmoCollectsound;
	private void OnTriggerEnter() {
		if(ammoCollect.ammo < 10 && m9.activeSelf){
			ammoCollect.ammo += 5;
			AmmoCollectsound.Play();
			if(ammoCollect.ammo > 10){
				ammoCollect.ammo = 10;
			}
			// Destroy(gameObject);
		}

	}
}
