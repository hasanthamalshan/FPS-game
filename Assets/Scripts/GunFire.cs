using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
	public AudioSource gunsound;

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			if(ammoCollect.ammo > 0){
				gunsound.Play();
				GetComponent<Animation>().Play();
				ammoCollect.ammo--;
			}
			
		}
	}
}
