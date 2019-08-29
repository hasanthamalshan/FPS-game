using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFireMP5K : MonoBehaviour {
	public AudioSource gunsound;
	public AudioSource emptygun;
	public AudioSource reloadsound;


	[SerializeField] GameObject Flash;

	bool isfiring = false;

	public static bool isrealoading = false;


	void Update () {
		if(Input.GetMouseButton(0) && isrealoading == false && isfiring == false){
			if(ammoCollect1.ammoLoadMP5K > 0 ){
				StartCoroutine("Fire",0.1f);
			}else{
				StartCoroutine("FireEmpty",0.1f);
				
			}
			
		}
		if(Input.GetKeyDown("r")){
			if(ammoCollect1.ammoMP5K > 0){
				StartCoroutine("ReloadWait",1.0f);
				reloadsound.Play();
				GetComponent<Animation>().Play("ReloadMP5K");
				ammoCollect1.ammoMP5K--;
				ammoCollect1.ammoLoadMP5K = 100;	
			}	
		}
	}
	IEnumerator ReloadWait(float time){

		isrealoading = true ; 

		yield return new WaitForSeconds(time);

		isrealoading = false;
		
	}
	IEnumerator FlashWait(float time){

		Flash.SetActive(true);

		yield return new WaitForSeconds(time);

		Flash.SetActive(false);
		
	}
	IEnumerator Fire(float time){
		isfiring = true;
		StartCoroutine("FlashWait",0.1f);
		gunsound.Play();
		GetComponent<Animation>().Play("GunfireMP5K");
		ammoCollect1.ammoLoadMP5K--;
		yield return new WaitForSeconds(time);	
		isfiring = false;
	}
	IEnumerator FireEmpty(float time){
		isfiring = true;
		emptygun.Play();
		yield return new WaitForSeconds(time);	
		isfiring = false;
	}
}
