using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

	//int DamageAmount = 5;
	//float TargetDistance;
	float AllowedRange = 15;

	public Camera fpsCam;
	

	void Update (){
		RaycastHit Hit;
		if(Input.GetMouseButtonDown(0)){
			if(Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out Hit , AllowedRange)){

					Debug.Log(Hit.transform.name);

			}
		}
	}
}
