using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ammoCollect : MonoBehaviour {

	public static int ammo = 10;
	public Text ammoCount;
	void Update () {
		ammoCount.text = ammo.ToString();

	}
}
