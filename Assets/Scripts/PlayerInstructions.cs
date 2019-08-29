using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerInstructions : MonoBehaviour
{
    [SerializeField] Text instructions;
    [SerializeField] GameObject Door;
    [SerializeField] GameObject m9take;
    [SerializeField] GameObject mp5ktake;

    public  GameObject mp5k;
    public GameObject m9;
    [SerializeField] GameObject ammoDisplay;
    [SerializeField] Text gun;

    [SerializeField] GameObject m9ammo;
    [SerializeField] GameObject mp5kammo;
    [SerializeField] GameObject m9Loadedammo;
    [SerializeField] GameObject mp5kLoadedammo;

    
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
                         mp5k.SetActive(false);
                         gun.text="M9";
                         
                    }
                }
                else if(Hit.transform.tag == "MP5K"){
                    instructions.text = "Press E to Take the MP5K Hand Gun";
                    if(Input.GetKeyDown("e")){
                         mp5k.SetActive(true);
                         ammoDisplay.SetActive(true);
                         mp5ktake.SetActive(false);
                         m9.SetActive(false);
                         gun.text="MP5K";
                         
                    }
			    }
		}else{
                    instructions.text = "";
                }
        if(m9.activeSelf == false && mp5k.activeSelf == true){
            m9ammo.SetActive(false);
            m9Loadedammo.SetActive(false);
            mp5kammo.SetActive(true);
            mp5kLoadedammo.SetActive(true);
        }else if(m9.activeSelf == true && mp5k.activeSelf == false){
            m9ammo.SetActive(true);
            m9Loadedammo.SetActive(true);
            mp5kammo.SetActive(false);
            mp5kLoadedammo.SetActive(false);
        }else{
            m9ammo.SetActive(false);
            m9Loadedammo.SetActive(false);
            mp5kammo.SetActive(false);
            mp5kLoadedammo.SetActive(false);
        }
        
    }
}
