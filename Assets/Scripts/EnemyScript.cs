using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	int EnemyHealth = 20;

	void deductPoints(int DamageAmount){
		EnemyHealth -= DamageAmount;
	}

    private void Update() {
		if(EnemyHealth <= 0){
			Destroy(gameObject);
		}	
	}
}
