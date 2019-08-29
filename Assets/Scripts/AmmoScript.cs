using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour {

	[SerializeField] GameObject m9;
	

	public AudioSource AmmoCollectsound;
	private void OnTriggerEnter() {
		if(CollectAmmoM9.ammoM9 < 10 && m9.activeSelf){
			CollectAmmoM9.ammoM9 += 5;
			AmmoCollectsound.Play();
			if(CollectAmmoM9.ammoM9 > 10){
				CollectAmmoM9.ammoM9 = 10;
			}
			// Destroy(gameObject);
		}

	}
}
