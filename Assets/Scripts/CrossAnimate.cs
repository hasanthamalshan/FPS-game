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
	[SerializeField] GameObject mp5k;

	public Camera fpsCam;

    float AllowedRangem9 = 15f;
	float AllowedRangemp5k = 30f;

	void Update () {
		RaycastHit Hit;
		// if(Input.GetMouseButtonDown(0)){
		// 	StartCoroutine("anim",0.1f);
		// }
		if(((Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out Hit , AllowedRangem9)) 
			&& m9.activeSelf) ||((Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out Hit , AllowedRangemp5k)) && mp5k.activeSelf)){
			 upImage.color = new Color32(255,0,0,255);
			 downImage.color = new Color32(255,0,0,255);
			 leftImage.color = new Color32(255,0,0,255);
			 rightImage.color = new Color32(255,0,0,255);
		}else{
			upImage.color = new Color32(255,255,255,255);
			downImage.color = new Color32(255,255,255,255);
			leftImage.color = new Color32(255,255,255,255);
			rightImage.color = new Color32(255,255,255,255);

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
