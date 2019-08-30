using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

	int DamageAmount = 5;
	float AllowedRangem9 = 15;

	public Camera fpsCam;

	RaycastHit bullet;
	[SerializeField] GameObject bullethole;
	

	void Update (){
		RaycastHit Hit;
		if(Input.GetMouseButtonDown(0) && CollectAmmoM9.ammoLoadM9 >0){
			if(Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out Hit , AllowedRangem9)){
				if(Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out bullet)){
						Instantiate(bullethole,bullet.point,Quaternion.LookRotation(Vector3.up,bullet.normal));
					}
				if(Hit.transform.tag == "enemy"){
					Hit.transform.SendMessage("deductPoints",DamageAmount);	
				}
			}
		}
	}
}
