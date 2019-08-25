using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ammoCollect : MonoBehaviour {

	public static int ammo = 0;
	public static int ammoLoad = 0;
	public Text ammoCount;
	public Text ammoLoaded;
	void Update () {
		ammoCount.text = ammoLoad.ToString();
		ammoLoaded.text = "x" + ammo.ToString();

	}
}
