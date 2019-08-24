﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
	public AudioSource gunsound;
	public AudioSource reloadsound;

	public static bool isrealoading = false;

	void Update () {
		if(Input.GetMouseButtonDown(0) && isrealoading == false){
			if(ammoCollect.ammoLoad > 0){
				gunsound.Play();
				GetComponent<Animation>().Play("GunShot");
				ammoCollect.ammoLoad--;
			}
			
		}
		if(Input.GetKeyDown("r")){
			if(ammoCollect.ammo > 0){
				StartCoroutine("ReloadWait",1.0f);
				reloadsound.Play();
				GetComponent<Animation>().Play("gunReload");
				ammoCollect.ammo--;
				ammoCollect.ammoLoad = 10;	
			}	
		}
	}
	IEnumerator ReloadWait(float time){

		isrealoading = true ; 

		yield return new WaitForSeconds(time);

		isrealoading = false;
		
	}
}
