using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFireMP5K : MonoBehaviour {
	public AudioSource gunsound;
	public AudioSource emptygun;
	public AudioSource reloadsound;


	[SerializeField] GameObject Flash;

	public static bool isrealoading = false;


	void Update () {
		if(Input.GetMouseButtonDown(0) && isrealoading == false){
			if(ammoCollect1.ammoLoadMP5K > 0){
				StartCoroutine("FlashWait",0.1f);
				gunsound.Play();
				//GetComponent<Animation>().Play("GunShot");
				ammoCollect1.ammoLoadMP5K--;
			}else{
				emptygun.Play();
			}
			
		}
		if(Input.GetKeyDown("r")){
			if(ammoCollect1.ammoMP5K > 0){
				StartCoroutine("ReloadWait",1.0f);
				reloadsound.Play();
				//GetComponent<Animation>().Play("gunReload");
				ammoCollect1.ammoMP5K--;
				ammoCollect1.ammoLoadMP5K = 10;	
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
}
