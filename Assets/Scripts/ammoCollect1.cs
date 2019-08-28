using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ammoCollect1 : MonoBehaviour {

	public static int ammoMP5K = 0;
	public static int ammoLoadMP5K = 0;
	public Text ammoCount;
	public Text ammoLoaded;
	void Update () {
		ammoCount.text = ammoLoadMP5K.ToString();
		ammoLoaded.text = "x" + ammoMP5K.ToString();

	}
}
