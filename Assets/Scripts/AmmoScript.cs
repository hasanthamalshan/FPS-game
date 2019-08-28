using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour {

	[SerializeField] GameObject m9;
	

	public AudioSource AmmoCollectsound;
	private void OnTriggerEnter() {
		if(ammoCollect.ammoM9 < 10 && m9.activeSelf){
			ammoCollect.ammoM9 += 5;
			AmmoCollectsound.Play();
			if(ammoCollect.ammoM9 > 10){
				ammoCollect.ammoM9 = 10;
			}
			// Destroy(gameObject);
		}

	}
}
