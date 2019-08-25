using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {
    [SerializeField] GameObject upMark;
	[SerializeField] GameObject downMark;
	[SerializeField] GameObject leftMark;
	[SerializeField] GameObject rightMark;

	public RawImage upImage;
	public RawImage downImage;
	public RawImage leftImage;
	public RawImage rightImage;
	[SerializeField] GameObject m9;
	public Camera fpsCam;

    float AllowedRange = 15f;

	void Update () {
		RaycastHit Hit;
		if(Input.GetMouseButtonDown(0)){
			StartCoroutine("anim",0.1f);
		}
		if((Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out Hit , AllowedRange)) && m9.activeSelf){
			upImage.GetComponent<Image>().color = new Color32(255,0,0,100);
			downImage.GetComponent<Image>().color = new Color32(255,0,0,100);
			leftImage.GetComponent<Image>().color = new Color32(255,0,0,100);
			rightImage.GetComponent<Image>().color = new Color32(255,0,0,100);
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
