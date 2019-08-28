using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ammoCollect : MonoBehaviour {

	public static int ammoM9 = 0;
	public static int ammoLoadM9 = 0;
	public Text ammoCount;
	public Text ammoLoaded;
	void Update () {
		ammoCount.text = ammoLoadM9.ToString();
		ammoLoaded.text = "x" + ammoM9.ToString();

	}
}
