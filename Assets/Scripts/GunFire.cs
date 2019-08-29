using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
	public AudioSource gunsound;
	public AudioSource emptygun;
	public AudioSource reloadsound;


	[SerializeField] GameObject Flash;

	public static bool isrealoading = false;


	void Update () {
		if(Input.GetMouseButtonDown(0) && isrealoading == false){
			if(CollectAmmoM9.ammoLoadM9 > 0){
				StartCoroutine("FlashWait",0.1f);
				gunsound.Play();
				GetComponent<Animation>().Play("GunShot");
				CollectAmmoM9.ammoLoadM9--;
			}else{
				emptygun.Play();
			}
			
		}
		if(Input.GetKeyDown("r")){
			if(CollectAmmoM9.ammoM9 > 0){
				StartCoroutine("ReloadWait",1.0f);
				reloadsound.Play();
				GetComponent<Animation>().Play("gunReload");
				CollectAmmoM9.ammoM9--;
				CollectAmmoM9.ammoLoadM9 = 10;	
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
