﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoScriptMp5k : MonoBehaviour
{
    [SerializeField] GameObject mp5k;
	

	public AudioSource AmmoCollectsound;
	private void OnTriggerEnter() {
		if(ammoCollect1.ammoMP5K < 50 && mp5k.activeSelf){
			ammoCollect1.ammoMP5K += 10;
			AmmoCollectsound.Play();
			if(ammoCollect1.ammoMP5K > 50){
				ammoCollect1.ammoMP5K = 50;
			}
			// Destroy(gameObject);
		}

	}
}
