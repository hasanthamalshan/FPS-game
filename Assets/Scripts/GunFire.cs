using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
	public AudioSource gunsound;
	public AudioSource reloadsound;

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			if(ammoCollect.ammoLoad > 0){
				gunsound.Play();
				GetComponent<Animation>().Play();
				ammoCollect.ammoLoad--;
			}
			
		}
		if(Input.GetKeyDown("r")){
			if(ammoCollect.ammo > 0){
				reloadsound.Play();
				//GetComponent<Animation>().Play();
				ammoCollect.ammo--;
				ammoCollect.ammoLoad = 10;
			}
			
		}
	}
}
