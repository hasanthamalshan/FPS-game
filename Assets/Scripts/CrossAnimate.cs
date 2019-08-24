using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {
    [SerializeField] GameObject upMark;
	[SerializeField] GameObject downMark;
	[SerializeField] GameObject leftMark;
	[SerializeField] GameObject rightMark;

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			StartCoroutine("anim",0.1f);
		}
	}

	IEnumerator anim(float time){
		yield return new WaitForSeconds(time);
		upMark.GetComponent<Animation>().Play();
		downMark.GetComponent<Animation>().Play();
		leftMark.GetComponent<Animation>().Play();
		rightMark.GetComponent<Animation>().Play();
		
	}
}
