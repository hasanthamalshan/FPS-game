using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {

	GameObject upMark;
	GameObject downMark;
	GameObject leftMark;
	GameObject rightMark;

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			upMark.GetComponent<Animation>().Play();
			downMark.GetComponent<Animation>().Play();
			leftMark.GetComponent<Animation>().Play();
			rightMark.GetComponent<Animation>().Play();
		}
	}

	
}
