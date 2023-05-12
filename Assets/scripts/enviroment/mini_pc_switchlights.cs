using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_pc_switchlights : MonoBehaviour{
	public Material yellow_on;
	public Material yellow_off;
	public Material green_on;
	public Material green_off;
	public GameObject net;
	public GameObject hdd;
	public float timer;
	public int rnd;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
			rnd=Random.Range(0, 5); 
			timer+=Time.deltaTime;
			if (timer>0.25 & timer<0.5){
				net.gameObject.GetComponent<Renderer>().material=yellow_on;
				if (rnd==0){hdd.gameObject.GetComponent<Renderer>().material=green_on;} 
				
				
			}
			if (timer>0.5 && timer<0.75)
			{
				net.gameObject.GetComponent<Renderer>().material=yellow_on; 
				
				
			}
			if (timer>0.75 & timer<1){
				net.gameObject.GetComponent<Renderer>().material=yellow_off; 
				
			}
			
			
		
		if (timer>1){
			net.gameObject.GetComponent<Renderer>().material=yellow_on;
			hdd.gameObject.GetComponent<Renderer>().material=green_off; 
		timer=0;}
		
		
	
    }
    

}