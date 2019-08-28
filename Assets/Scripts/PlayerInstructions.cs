using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerInstructions : MonoBehaviour
{
    [SerializeField] Text instructions;
    [SerializeField] GameObject Door;
    [SerializeField] GameObject m9take;

    [SerializeField] GameObject m9;
    [SerializeField] GameObject ammoDisplay;
    [SerializeField] Text gun;

    
    public Camera fpsCam;

    float AllowedRange = 2f;

    void Update()
    {
        RaycastHit Hit;
		
		if(Physics.Raycast(fpsCam.transform.position , fpsCam.transform.forward , out Hit , AllowedRange)){
				if(Hit.transform.tag == "doorButton1"){
                    instructions.text = "Press E to Open Door";
                    if(Input.GetKeyDown("e")){
                         Door.GetComponent<Animation>().Play();
                    }
			    }
                else if(Hit.transform.tag == "M9"){
                    instructions.text = "Press E to Take the M9 Hand Gun";
                    if(Input.GetKeyDown("e")){
                         m9.SetActive(true);
                         ammoDisplay.SetActive(true);
                         m9take.SetActive(false);
                         gun.text="M9";
                         
                    }
			    }
		}else{
                    instructions.text = "";
                }
    }
}
